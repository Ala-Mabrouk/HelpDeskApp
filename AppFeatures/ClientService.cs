using Entities.Entities;
using Entity_DAL.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppFeatures
{
    public class ClientService
    {

        //making a globale DataBaseContext variable :
        private static DataBaseContext _context = new DataBaseContext(DataBaseContext.ops.dbOptions);


        public Person SignUp(Client cl)
        {


            //cheking if email dont exist already
            var t = _context.Clients.Where(c => c.Email.Equals(cl.Email)).FirstOrDefault();

            if (t == null)
            {
                //we need to encrypte the password before saving it in the database 
                // we are using " BCrypt.Net " package to do that

                string newPass = BCrypt.Net.BCrypt.HashPassword(cl.Password);

                cl.Password = newPass;
                _context.Add(cl);
                _context.SaveChanges();


                //adding default permissions

                //getting the default permission using the role so we can add it to the client
                List<Permission> listClientpermissions = _context.DefaultPermissions.Where(s => s.roleId == cl.roleId).Select(s => s.permission).ToList();



                Person c = _context.Clients.Where(s => s.Email == cl.Email).FirstOrDefault();

                foreach (var item in listClientpermissions)
                {
                    _context.Add(new UserPermission { person = c, permision = item });
                    _context.SaveChanges();

                }


                _context.Update(c);
                _context.SaveChanges();


                return c;
            }
            else
                return null;
        }

        public Client GetUser(int id)
        {
            return _context.Clients.SingleOrDefault(u => u.Id == id);

        }



    }
}
