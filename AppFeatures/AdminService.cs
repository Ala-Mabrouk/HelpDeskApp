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
    public class AdminService
    {
        private static DataBaseContext _context = new DataBaseContext(DataBaseContext.ops.dbOptions);





        public async Task<List<User>> ShowAgents()
        {

            List<User> res = await _context.Users
              .Include(p => p.role)
              .Include(p => p.listUserPermissions).
              ThenInclude(pp => pp.permision).Where(p=>p.role.roleName.Equals("Agent")).ToListAsync();

            return res;
        }

        public async Task<Boolean> changePermissions(List<int> lp, int id)
        {
            try
            {
                //we will make like an overrride
                //remove old userpermissions 
                var a = await _context.UserPermissions.Where(c => c.userId == id).ToListAsync();
                _context.UserPermissions.RemoveRange(a);
                await _context.SaveChangesAsync();


                //saving new permissions
                foreach (var item in lp)
                {
                    await _context.AddAsync(new UserPermission { userId = id, permisionId = item });
                    await _context.SaveChangesAsync();
                }

                return true;

            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return false;
            }
        }

    }




}

