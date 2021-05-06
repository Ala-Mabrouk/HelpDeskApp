using Entities.Entities;
using Entity_DAL.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFeatures
{
    public class Userservice  
    {

        //making a globale DataBaseContext variable :
        private static DataBaseContext _context = new DataBaseContext(DataBaseContext.ops.dbOptions);

        public async Task<User> LogIn(string mail, string pass)
        {
            User res =await _context.Users.Include(p => p.role).FirstOrDefaultAsync(p => p.Email.Equals(mail));



            if (res != null && BCrypt.Net.BCrypt.Verify(pass, res.Password))
                return res;

            else return null;

        }


        public async Task createTicket(Ticket ticket)
        {
            await _context.AddAsync(ticket);
           await _context.SaveChangesAsync();

        }
        public async Task<User> updateInfo(User pers)
        {
      

            User person = await _context.Users.Where(p=>p.Id==pers.Id).FirstAsync();

            person.FirstName= pers.FirstName;
            person.LastName = pers.LastName;
            person.Email = pers.Email;
            person.Phone = pers.Phone;
            person.HomeAdresse = pers.HomeAdresse;
              
            await _context.SaveChangesAsync();

             return person;

        }

        public async Task<Boolean> changeUserPassword(string mail, string oldPassword,string newPassword)
        {
            User person =await _context.Users.Where(p => p.Email == mail).FirstAsync();
            if (BCrypt.Net.BCrypt.Verify(oldPassword, person.Password))
            {

                string newPass = BCrypt.Net.BCrypt.HashPassword(newPassword);
                person.Password = newPass;
              await  _context.SaveChangesAsync();

                return true;
            }
            return false;

        }

    }


}
