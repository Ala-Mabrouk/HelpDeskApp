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
    public class AdminServices : AgentServices
    {
        private static DataBaseContext _context = new DataBaseContext(DataBaseContext.ops.dbOptions);

        public async Task<List<Agent>> ShowAgents()
        {

            List<Agent> res = await _context.Agents
              .Include(p => p.role)
              .Include(p => p.listUserPermissions).
              ThenInclude(pp => pp.permision).Where(p => p.role.roleId >= 4).ToListAsync();

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
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return false;
            }
        }


        public async Task<Agent> addAgent(Agent a)
        {
            try
            {

                // ********cheking if email dont exist already********

                Agent e = await _context.Agents.Where(ag => ag.Email.Equals(a.Email)).FirstOrDefaultAsync();

                if (e == null)
                {
                    //we need to encrypte the password before saving it in the database 
                    // we are using " BCrypt.Net " package to do that

                    string newPass = BCrypt.Net.BCrypt.HashPassword(a.Password);

                    a.Password = newPass;
                    await _context.AddAsync(a);
                    await _context.SaveChangesAsync();


                    // ********adding default permissions********

                    //getting the default permission using the role so we can add it to the client
                    List<Permission> listPermissions = await _context.DefaultPermissions.Where(s => s.roleId == a.roleId).Select(s => s.permission).ToListAsync();


                    Agent c = await _context.Agents.Include(r => r.role).Where(s => s.Email == a.Email).FirstOrDefaultAsync();

                    foreach (var item in listPermissions)
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


        //used to change selected agent password
        public async Task<Boolean> changeAgentPassword(string agentEmail,string newPassword)
        {
            try
            {
                User person = await _context.Users.Where(p => p.Email == agentEmail).FirstAsync();

                string newPass = BCrypt.Net.BCrypt.HashPassword(newPassword);
                person.Password = newPass;
                await _context.SaveChangesAsync();
                return true;
            }
            catch(Exception e)
            { 
                return false;

            }
           
        }



    }
}

