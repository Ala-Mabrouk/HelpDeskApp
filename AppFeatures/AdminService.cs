using Entities.Entities;
using Entity_DAL.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppFeatures
{
    public class AdminService
    {
        private static DataBaseContext _context = new DataBaseContext(DataBaseContext.ops.dbOptions);





        public List<Person> ShowAgents()
        {

            List<Person> res = _context.Persons
              .Include(p => p.role)
              .Include(p => p.listUserPermissions).
              ThenInclude(pp => pp.permision).ToList();

            return res;
        }

        public Boolean changePermissions(List<int> lp, int id)
        {
            try
            {
                //we will make like an overrride
                //remove old userpermissions 
                var a = _context.UserPermissions.Where(c => c.personId == id).ToList();
                _context.UserPermissions.RemoveRange(a);
                _context.SaveChanges();


                //saving new permissions
                foreach (var item in lp)
                {
                    _context.Add(new UserPermission { personId = id, permisionId = item });
                    _context.SaveChanges();
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

