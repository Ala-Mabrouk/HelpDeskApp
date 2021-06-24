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


    // the commun function between actors is declared here

    public class Userservices
    {

        //making a globale DataBaseContext variable :
        private static DataBaseContext _context = new DataBaseContext(DataBaseContext.ops.dbOptions);

        public async Task<User> SignUp(Client cl)
        {
            try
            {

                // ********cheking if email dont exist already********

                Client e = await _context.Clients.Where(c => c.Email.Equals(cl.Email)).FirstOrDefaultAsync();

                if (e == null)
                {
                    //we need to encrypte the password before saving it in the database 
                    // we are using " BCrypt.Net " package to do that

                    string newPass = BCrypt.Net.BCrypt.HashPassword(cl.Password);

                    cl.Password = newPass;
                    await _context.AddAsync(cl);
                    await _context.SaveChangesAsync();


                    // ********adding default permissions********

                    //getting the default permission using the role so we can add it to the client
                    List<Permission> listClientpermissions = await _context.DefaultPermissions.Where(s => s.roleId == cl.roleId).Select(s => s.permission).ToListAsync();


                    User c = await _context.Clients.Include(r => r.role).Where(s => s.Email == cl.Email).FirstOrDefaultAsync();

                    foreach (var item in listClientpermissions)
                    {

                        await _context.AddAsync(new UserPermission { user = c, permision = item });
                        await _context.SaveChangesAsync();

                    }


                    _context.Update(c);
                    await _context.SaveChangesAsync();
                    return c;
                }


            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return null;

            }


            return null;
        }

        public async Task<User> LogIn(string mail, string pass)
        {
            User res = await _context.Users.Include(p => p.role).FirstOrDefaultAsync(p => p.Email.Equals(mail));



            if (res != null && BCrypt.Net.BCrypt.Verify(pass, res.Password))
                return res;

            else return null;

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
