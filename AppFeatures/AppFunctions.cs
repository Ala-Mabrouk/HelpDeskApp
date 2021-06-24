using Entities.Entities;
using Entity_DAL.DAL;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFeatures
{
    public class AppFunctions
    {
        //making a globale DataBaseContext variable :
        private static DataBaseContext _context = new DataBaseContext(DataBaseContext.ops.dbOptions);




        //***** USER,ROLE?PERMISSIONS

        public async Task<User> GetUserByEmail(string email)
        {

            User a = await _context.Users
                 .Include(p => p.role)
                 .Include(p => p.listUserPermissions)
                 .ThenInclude(c => c.permision)
                 .FirstOrDefaultAsync(p => p.Email == email);


            return a;

        }

        public List<Permission> getUserPermissions(string email)
        {
            var a = _context.Users
                .Include(c => c.listUserPermissions)
                .ThenInclude(ca => ca.permision)
                .FirstOrDefault(c => c.Email == email);

            List<Permission> p = new List<Permission>();

            foreach (var item in a.listUserPermissions)
            {
                p.Add(item.permision);

            }

            return p;
        }

        public List<Permission> ShowAllPermissions()
        {
            return (_context.Permissions.ToList());
        }

        public List<Role> getRolesForAgents()
        {
            var res = _context.Roles.ToList();
            List<Role> res2 = new List<Role>();
            foreach (var item in res)
            {


                if (item.roleName != "SuperAdmin" && item.roleName != "Admin" && item.roleName != "Client")

                    res2.Add(item);
            }

            return res2;
        }

        public Permission getPermissionById(int pID)
        {
            var res = _context.Permissions.FirstOrDefault(p => p.permissionId == pID);
            return res;
        }


        public void addpermissionToAgent(Permission _permission, string agentMail)
        {
            User a = GetUserByEmail(agentMail).Result;
            _context.UserPermissions.Add(new UserPermission { permision = _permission, user = a });
            _context.SaveChanges();



        }

        public void deletepermissionToAgent(Permission _permission, string agentMail)
        {
            User a = GetUserByEmail(agentMail).Result;

            UserPermission _userPermission = _context.UserPermissions.FirstOrDefault(up => up.permisionId == _permission.permissionId && up.userId == a.Id);
            _context.UserPermissions.Remove(_userPermission);
            _context.SaveChanges();
        }


        public async Task<bool> resetPassword(string emailAdress, string phone)
        {
            User u = GetUserByEmail(emailAdress).Result;
            if (u != null)
            {
                if (u.Phone == phone)
                {
                    //send new password
                    string pass = generatePassword(8);
                    Client e = _context.Clients.Where(c => c.Email.Equals(emailAdress)).FirstOrDefault();


                    e.Password = BCrypt.Net.BCrypt.HashPassword(pass);
                    _context.SaveChanges();

                    await sendClientPasswordNotification(emailAdress, pass);

                    return true;
                }
            }


            return false;

        }

        public string generatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }










        //***** TICKETS MANAGEMENT
        public async Task<List<Ticket>> showAllTickets()
        {
            var myList = await _context.Tickets.Where(t => t.ticketStatut != Ticket.TicketStatus.Closed).ToListAsync();
            return (myList);
        }

        public async Task<Ticket> addTicket(Ticket ticket)
        {
            try
            {
                await _context.AddAsync(ticket);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }
            return (ticket);
        }

        public async Task<Boolean> closeTicket(int ticketid)
        {
            try
            {
                var res = await _context.Tickets.FindAsync(ticketid);
                res.ticketStatut = Ticket.TicketStatus.Closed;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<List<Ticket>> getTicketsByUser(int id)
        {

            var res = await _context.Tickets
                  .Include(t => t.creator_user).Where(t => t.userId == id).ToListAsync();
            return res;

        }

        public async Task<Ticket> ticketInfo(int ticketId)
        {


            var res = await _context.Tickets.Include(t => t.creator_user).FirstOrDefaultAsync(t => t.ticketId == ticketId);
            System.Diagnostics.Debug.WriteLine(res.ticketTitle);

            /*System.Diagnostics.Debug.WriteLine("les Produit "+res.relatedProduct.factoryName);
            System.Diagnostics.Debug.WriteLine("the user "+res.creator_user.LastName);*/

            return (res);
        }

        public async Task<List<Reply>> getTicketReplies(int idTicket)
        {
            try
            {
                var res = await _context.Replys.Where(r => r.TicketId == idTicket).Include(r => r.replyOwner).Include(r => r.replyOwner.role).OrderBy(r => r.reply_date).ToListAsync();
                return res;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }
        }

        public async Task<Ticket> getTicketDetails(int ticketId)
        {
            var res = await _context.Tickets.Include(t => t.creator_user).Include(t => t.relatedProduct).FirstOrDefaultAsync(t => t.ticketId == ticketId);
            return res;
        }

        public Boolean workOnTicket(string agentMail, int ticketId)
        {
            try
            {
                Ticket t = _context.Tickets.FirstOrDefault(t => t.ticketId == ticketId);
                Agent a = _context.Agents.FirstOrDefault(a => a.Email.Equals(agentMail));


                A_T_Managment at = new A_T_Managment { ticket = t, agent = a };

                _context.Add(at);
                t.listAT_Management.Add(at);
                t.ticketStatut = Ticket.TicketStatus.Open;
                a.a_T_ManagmentsList.Add(at);


                _context.SaveChanges();



                return true;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("******" + e);
                return false;
            }
        }

        public List<Ticket> getAgentTickets(string agentMail)
        {
            var res2 = new List<Ticket>();
            var res = _context.A_T_Managments.Include(t => t.ticket).Where(a => ((string)a.agent.Email).Equals(agentMail)).ToList();
            foreach (var item in res)
            {
                if (item.ticket.ticketStatut != Ticket.TicketStatus.Closed)
                    res2.Add(item.ticket);

            }


            return res2;


        }

        public async Task<Reply> addReply(Reply ticketReply)
        {

            //do we need to add the reply to the listOfReplies in ticket_Entity

            await _context.AddAsync(ticketReply);
            await _context.SaveChangesAsync();


            return ticketReply;
        }

        public async Task<Boolean> changeTicketStatus(int idTicket, Ticket.TicketStatus newStatus)
        {
            try
            {
                var res = await _context.Tickets.FirstOrDefaultAsync(t => t.ticketId == idTicket);
                res.ticketStatut = newStatus;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public Boolean assignTicket(int ticketid, int agentid)
        {
            try
            {

                var a = _context.A_T_Managments.FirstOrDefault(a => a.ticketId == ticketid);

                var ticket = _context.Tickets.FirstOrDefault(t => t.ticketId == ticketid);
                var agent = _context.Agents.FirstOrDefault(t => t.Id == agentid);

                if (a != null)
                {
                    _context.A_T_Managments.Remove(a);
                }
                A_T_Managment at = new A_T_Managment { ticket = ticket, agent = agent, dateAssign = DateTime.Now };
                _context.Add(at);
                ticket.listAT_Management.Add(at);
                ticket.ticketStatut = Ticket.TicketStatus.Open;
                ticket.ticketPriority = Ticket.TicketPriority.High;
                agent.a_T_ManagmentsList.Add(at);

                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return false;
            }


        }









        //******* PRODUCTS MANAGMENT
        public async Task<List<Product>> getListProducts()
        {
            List<Product> res = await _context.Products.ToListAsync();
            return res;
        }

        public async Task<Product> getProductById(string id)
        {
            var res = await _context.Products.FirstOrDefaultAsync(p => p.refId == id);
            return res;
        }

        public async Task<Product> addProduct(Product p)
        {
            try
            {
                await _context.AddAsync(p);
                await _context.SaveChangesAsync();
                return p;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }
        }

        public async Task<Product> updateProduct(Product p)
        {
            try
            {
                var res = await _context.Products.FirstAsync(p => p.refId == p.refId);
                res.name = p.name;
                res.description = p.description;
                res.dateBuild = p.dateBuild;
                res.dateValidate = p.dateValidate;
                res.factoryName = p.factoryName;
                res.category = p.category;

                await _context.SaveChangesAsync();
                return res;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }
        }

        public async Task<Boolean> DeleteProduct(string idproduct)
        {
            try
            {
                var res = _context.Products.Where(P => P.refId == idproduct).First();
                _context.Remove(res);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return false;
            }
        }

        public async Task<List<Product>> findProduct(string key)
        {

            List<Product> res = await _context.Products.Where(p => p.name.Contains(key)).ToListAsync();
            return res;

        }

        public List<Product> getAllProducts()
        {
            return _context.Products.ToList();
        }

        public async Task<List<Product>> getLatestProducts()
        {
            return await _context.Products.OrderByDescending(p => p.addedDate).Take(3).ToListAsync();
        }

        public async Task<Boolean> addProductClient(string prodRef, string email)
        {
            System.Diagnostics.Debug.WriteLine("++++++" + prodRef);


            Client client = (Client)GetUserByEmail(email).Result;

            var p = _context.Products.FirstOrDefault(pr => pr.refId == prodRef);

            ProductClient pc = new ProductClient { client = client, product = p, date = DateTime.Now };

            try
            {

                await _context.AddAsync(pc);

                //adding the ProductClient to myListProducts


                Product prod = _context.Products.FirstOrDefaultAsync(p => p.refId == prodRef).Result;

                prod.ListProductClient.Add(pc);

                //adding the ProductClient to ListProductClient

                client.myListProducts.Add(pc);

                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return false;
            }


        }

        public List<Product> getClientProducts(int clientId)
        {
            try
            {
                List<Product> res = _context.ProductClients.Where(pc => pc.clientId == clientId).Select(pc => pc.product).ToList();
                System.Diagnostics.Debug.WriteLine(res.Count);

                if (res == null)
                {
                    return null;
                }

                return res;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }


        }









        //****** KNOWLEDGEBASE MANGMENT

        public async Task<Article> getArticleInfo(int idArticle)
        {
            Article _article = await _context.Articles.Include(a=>a.creator_agent).FirstOrDefaultAsync(a => a.ArticleId == idArticle);
            return _article;
        }

        public int getCountArticlesByCategory(string _category)
        {


            int res = _context.Articles.Where(a => a.category == _category).Count();

            return res;
        }

        public async Task<List<string>> getListCategories()
        {

            List<string> res = await _context.Articles.Select(a => a.category).Distinct().ToListAsync();
            return res;
        }

        public async Task<List<Article>> getListArticlesByCategory(string _category)
        {

            List<Article> res = await _context.Articles.Where(a => a.category == _category).Take(3).ToListAsync();
            return res;
        }

        public async Task<List<Article>> getListAllArticlesByCategory(string _category)
        {

            List<Article> res = await _context.Articles.Where(a => a.category == _category).ToListAsync();
            return res;
        }

        public async Task<List<Article>> getLatestArticles()
        {
            return await _context.Articles.OrderByDescending(a => a.lastModified).Take(3).ToListAsync();
        }

        public async Task<List<Article>> findArticles(string key)
        {
            List<Article> res = await _context.Articles.Where(p => p.Title.Contains(key)).ToListAsync();
            return res;
        }

        public async Task<List<Article>> getAllArticles()
        {
            var res = await _context.Articles.ToListAsync();
            return res;
        }

        public async Task<Boolean> addArticle(Article ar)
        {
            try
            {
              

                await _context.AddAsync(ar);
                await _context.SaveChangesAsync();

                return true;



            }
            catch (Exception e)
            {
                return false;
            }

        }

        public async Task<Boolean> removeArticle(int id)
        {
            try
            {
                Article a = await _context.Articles.FindAsync(id);
                _context.Articles.Remove(a);
               await _context.SaveChangesAsync();
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }

        public async Task<Article> updateArticle(Article ar)
        {
            var res = await _context.Articles.FirstAsync(a=>a.ArticleId == ar.ArticleId);
            res.Title = ar.Title;
            res.content = ar.content;
            res.category = ar.category;
            res.lastModified = ar.lastModified;
            res.creator_agentId = ar.creator_agentId;

            await _context.SaveChangesAsync();
            return res;
        }





        //********** NOTIFICATION SYSTEM


        public async Task sendClientNotification(string toAdress, string ticket, DateTime replydate)
        {
            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress("NSTgroup",
            "ntsgrouptunisie@gmail.com");
            message.From.Add(from);

            MailboxAddress to = new MailboxAddress(toAdress);
            message.To.Add(to);

            message.Subject = "ticket notification";

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "<h2>Hello " + toAdress + " your ticket :" + ticket + "has a new reply on :" + replydate + "</h2>";

            bodyBuilder.TextBody = "Hello " + toAdress + "your ticket : " + ticket + "has a new reply";

            message.Body = bodyBuilder.ToMessageBody();

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("ntsgrouptunisie@gmail.com", "26 288 297");
            await smtp.SendAsync(message);
            smtp.Disconnect(true);






        }

        public async Task sendClientPasswordNotification(string toAdress, string newPass)
        {
            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress("NSTgroup",
            "ntsgrouptunisie@gmail.com");
            message.From.Add(from);

            MailboxAddress to = new MailboxAddress(toAdress);
            message.To.Add(to);

            message.Subject = "ticket notification";

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "Hello " + toAdress + "your new password is: " + newPass + "";

            bodyBuilder.TextBody = "Hello " + toAdress + "your new password is: " + newPass + "";

            message.Body = bodyBuilder.ToMessageBody();

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("ntsgrouptunisie@gmail.com", "26 288 297");
            await smtp.SendAsync(message);
            smtp.Disconnect(true);
        }



        public void createNotificationAssignTicket(Notification noti)
        {
            _context.Add(noti);
            _context.SaveChanges();

        }

        public List<Notification> getUserNotification(int idUser)
        {
            DateTime now = DateTime.Now;
            var res = _context.Notifications.Where(n => n.notificationDate < now && n.reciverNotification == idUser).OrderByDescending(n => n.notificationDate).ToList();
            return res;
        }


    }
}
