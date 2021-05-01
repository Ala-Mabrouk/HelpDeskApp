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
        public Person updateInfo(Person pers)
        {
            System.Diagnostics.Debug.WriteLine("the id is =" + pers.Id);

            Person person =_context.Persons.Where(p=>p.Id==pers.Id).First();

            person.FirstName= pers.FirstName;
            person.LastName = pers.LastName;
            person.Email = pers.Email;
            person.Phone = pers.Phone;
            person.HomeAdresse = pers.HomeAdresse;
            

            System.Diagnostics.Debug.WriteLine("person new phone="+ person.Phone);
            _context.SaveChanges();

            System.Diagnostics.Debug.WriteLine("done saving new info");
            return person;

        }

        public Boolean changeUserPassword(int id, string oldPassword,string newPassword)
        {
            Person person = _context.Persons.Where(p => p.Id == id).First();
            if (BCrypt.Net.BCrypt.Verify(oldPassword, person.Password))
            {

                string newPass = BCrypt.Net.BCrypt.HashPassword(newPassword);
                person.Password = newPass;
                _context.SaveChanges();

                return true;
            }
            return false;

        }

    }


}
