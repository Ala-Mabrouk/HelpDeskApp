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

        public void changePermissions(List<int> lp, int id)
        {      //we will make like an overrride
            //remove old userpermissions 
            var a = _context.UserPermissions.Where(c => c.personId == id).ToList();
            foreach (var item in a)
            {
                System.Diagnostics.Debug.WriteLine(item.permision.permissionName);
            }
            _context.UserPermissions.RemoveRange(a);
            _context.SaveChanges();
            a = _context.UserPermissions.Where(c => c.personId == id).ToList();
            if (a.Count() == 0)
            {
                System.Diagnostics.Debug.WriteLine("list of old is deleted");
            }
            //saving new permissions
            foreach (var item in lp)
            {
                _context.Add(new UserPermission { personId = id, permisionId = item });
                _context.SaveChanges();
            }


        }

    }




}

