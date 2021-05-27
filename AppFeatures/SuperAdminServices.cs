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
    public class SuperAdminServices : AdminServices
    {
        private static DataBaseContext _context = new DataBaseContext(DataBaseContext.ops.dbOptions);
        public async Task<List<Admin>> ShowAdmins()
        {

            List<Admin> res = await _context.Admins
              .Include(p => p.role)
              .Include(p => p.listUserPermissions).
              ThenInclude(pp => pp.permision).Where(p => p.role.roleId == 2).ToListAsync();

            return res;
        }

        public async Task<Admin> addAdmin(Admin admin)
        {
            try
            {

                // ********cheking if email dont exist already********

                Admin myadmin = await _context.Admins.Where(ad => ad.Email.Equals(admin.Email)).FirstOrDefaultAsync();

                if (myadmin == null)
                {
                    //we need to encrypte the password before saving it in the database 
                    // we are using " BCrypt.Net " package to do that

                    string newPass = BCrypt.Net.BCrypt.HashPassword(admin.Password);

                    admin.Password = newPass;
                    await _context.AddAsync(admin);
                    await _context.SaveChangesAsync();


                    // ********adding default permissions********

                    //getting the default permission using the role so we can add it to the client
                    List<Permission> listPermissions = await _context.DefaultPermissions.Where(s => s.roleId == admin.roleId).Select(s => s.permission).ToListAsync();


                    Admin a = await _context.Admins.Include(r => r.role).Where(s => s.Email == admin.Email).FirstOrDefaultAsync();

                    foreach (var item in listPermissions)
                    {
                        await _context.AddAsync(new UserPermission { user = a, permision = item });

                        await _context.SaveChangesAsync();

                    }


                    _context.Update(a);
                    await _context.SaveChangesAsync();
                    return a;
                }


            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return null;

            }

            return null;

        }





    }
}
