using Entities.Entities;
using Entity_DAL.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppFeatures
{
    public class ClientServices : Userservices
    {

        //making a globale DataBaseContext variable :
        private static DataBaseContext _context = new DataBaseContext(DataBaseContext.ops.dbOptions);




    /*    public async Task<Client> GetUser(int id)
        {
            try
            {
                return await _context.Clients.SingleOrDefaultAsync(u => u.Id == id);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }

        }*/



    }
}
