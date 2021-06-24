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
    public class AgentServices : Userservices
    {
        private static DataBaseContext _context = new DataBaseContext(DataBaseContext.ops.dbOptions);



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

        public async Task<List<Client>> getAllCustomers()
        {
            List<Client> res = await _context.Clients
                .Include(p => p.role)
             .Where(p => p.role.roleName.Equals("Client")).ToListAsync();
            return res;
        }





    }
}
