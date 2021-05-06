using Entities.Entities;
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
            var  a = _context.Users
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
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }
            return (ticket);
        }

        public async  Task<List<Ticket>> getTicketsByUser(int id)
        {

          var res= await _context.Tickets
                .Include(t => t.creator_user).Where(t => t.userId == id).ToListAsync();
            return res;

        }

        public async Task<Ticket> ticketInfo(int ticketId)
        {

            Ticket res = await _context.Tickets.Include(t => t.creator_user).SingleOrDefaultAsync(t=>t.ticketId == ticketId);
            return(res);
        }


    }
}
