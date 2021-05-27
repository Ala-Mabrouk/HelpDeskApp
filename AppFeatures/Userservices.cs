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
    public class Userservices
    {

        //making a globale DataBaseContext variable :
        private static DataBaseContext _context = new DataBaseContext(DataBaseContext.ops.dbOptions);

        public async Task<User> LogIn(string mail, string pass)
        {
            User res = await _context.Users.Include(p => p.role).FirstOrDefaultAsync(p => p.Email.Equals(mail));



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


            User person = await _context.Users.Where(p => p.Id == pers.Id).FirstAsync();

            person.FirstName = pers.FirstName;
            person.LastName = pers.LastName;
            person.Email = pers.Email;
            person.Phone = pers.Phone;
            person.HomeAdresse = pers.HomeAdresse;
            if (!string.IsNullOrEmpty(pers.ThumbUrl))
                person.ThumbUrl = pers.ThumbUrl;

            await _context.SaveChangesAsync();

            return person;

        }
        public async Task<Agent> updateAgentInfo(Agent _agent)
        {


            Agent updatedAgent = await _context.Agents.Where(p => p.Id == _agent.Id).FirstAsync();

            updatedAgent.FirstName = _agent.FirstName;
            updatedAgent.LastName = _agent.LastName;
            updatedAgent.Email = _agent.Email;
            updatedAgent.Phone = _agent.Phone;
            updatedAgent.HomeAdresse = _agent.HomeAdresse;
            updatedAgent.status = _agent.status;

            await _context.SaveChangesAsync();

            return updatedAgent;

        }

        public async Task<Boolean> changeUserPassword(string mail, string oldPassword, string newPassword)
        {
            User person = await _context.Users.Where(p => p.Email == mail).FirstAsync();
            if (BCrypt.Net.BCrypt.Verify(oldPassword, person.Password))
            {

                string newPass = BCrypt.Net.BCrypt.HashPassword(newPassword);
                person.Password = newPass;
                await _context.SaveChangesAsync();
                System.Diagnostics.Debug.WriteLine("Password changed");
                return true;
            }
            return false;

        }

    }


}
