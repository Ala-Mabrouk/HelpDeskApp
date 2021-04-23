using Entities.Entities;
using Entity_DAL.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppFeatures
{
    public class PersonService
    {

        //making a globale DataBaseContext variable :
        private static DataBaseContext _context = new DataBaseContext(DataBaseContext.ops.dbOptions);

        public Person LogIn(string mail, string pass)
        {
            Person res = _context.Persons.Include(p => p.role).FirstOrDefault(p => p.Email.Equals(mail));



            if (res != null && BCrypt.Net.BCrypt.Verify(pass, res.Password))
                return res;

            else return null;

        }


        public void createTicket(Ticket ticket)
        {
            _context.Add(ticket);
            _context.SaveChanges();

        }

    }


}
