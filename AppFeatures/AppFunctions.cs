using Entities.Entities;
using Entity_DAL.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace AppFeatures
{
    public class AppFunctions
    {
        //making a globale DataBaseContext variable :
        private static DataBaseContext _context = new DataBaseContext(DataBaseContext.ops.dbOptions);



        public Person GetUserById(int id)
        {

            var a = _context.Persons
                 .Include(p => p.role)
                 .Include(p => p.listUserPermissions)
                 .ThenInclude(c => c.permision)
                 .FirstOrDefault(p => p.Id == id);


            return a;

        }

        public List<Permission> getUserPermissions(int id)
        {
            var a = _context.Persons
                .Include(c => c.listUserPermissions)
                .ThenInclude(ca => ca.permision)
                .FirstOrDefault(c => c.Id == id);
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

        public List<Ticket> showAllTickets(int id)
        {
            return (_context.Tickets.Where(t=>t.personId==id).ToList());
        }
        public Ticket addTicket(Ticket ticket)
        {
            _context.Add(ticket);
            return (ticket);
        }

        public List<Ticket> getTicketsByUser(int id)
        {

          var res=  _context.Tickets
                .Include(t => t.c_person).Where(t => t.personId == id).ToList();
            return res;

        }

        public Ticket ticketInfo(int ticketId)
        {

            Ticket res = _context.Tickets.Include(t => t.c_person).SingleOrDefault(t=>t.ticketId == ticketId);
            System.Diagnostics.Debug.WriteLine(res);
            return(res);
        }


    }
}
