﻿using Entities.Entities;
using Entity_DAL.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppFeatures
{
    public class AppFunctions
    {
        //making a globale DataBaseContext variable :
        private static DataBaseContext _context = new DataBaseContext(DataBaseContext.ops.dbOptions);



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

        public async Task<List<Ticket>> showAllTickets(int id)
        {
            var myList = await _context.Tickets.ToListAsync();
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

        public async Task<List<Ticket>> getTicketsByUser(int id)
        {

            var res = await _context.Tickets
                  .Include(t => t.creator_user).Where(t => t.userId == id).ToListAsync();
            return res;

        }

        public async Task<Ticket> ticketInfo(int ticketId)
        {

            Ticket res = await _context.Tickets.Include(t => t.creator_user).SingleOrDefaultAsync(t => t.ticketId == ticketId);
            return (res);
        }

        public async Task<Ticket> getTicketDetails(int ticketId)
        {
            Ticket res = await _context.Tickets.FirstOrDefaultAsync();
            return res;
        }

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


        public Boolean resetPass(string mail)
        {
            //supossed to save reclmation to base then admin handel it 
            return true;
        }
        public List<Product> getAllProducts()
        {
            return _context.Products.ToList();
        }



        public async Task<List<Product>> getLatestProducts()
        {
            return await _context.Products.OrderByDescending(p => p.addedDate).Take(3).ToListAsync();
        }





        public List<Role> getRolesForAgents()
        {
            var res = _context.Roles.ToList();
            List<Role> res2 = new List<Role>();
            foreach (var item in res)
            {


                if (item.roleName != "SupperAdmin" && item.roleName != "Admin" && item.roleName != "Client")

                    res2.Add(item);
            }

            return res2;
        }

        public async Task<Boolean> addProductClient(string prodRef, string email)
        {


            Client client = (Client)GetUserByEmail(email).Result;

            var p = _context.Products.FirstOrDefault(pr => pr.refId == prodRef);


            ProductClient pc = new ProductClient { client = client, product = p };

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
                 List<Product> res = _context.ProductClients.Where(pc => pc.clientId == clientId).Select(pc=>pc.product).ToList();
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

    }
}
