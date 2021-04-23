
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
 

namespace Entity_DAL.DAL

{
    //This class will allow us to interact with our database
    public class DataBaseContext : DbContext

    {
        //this class to intiate database connection and it's entity
        public class OptionBuild
        {

            //Allow us to configure the connection to database
            public DbContextOptionsBuilder<DataBaseContext> opsBuilder { get; set; }

            //We can obtain and hold on to database configuration information
            public DbContextOptions<DataBaseContext> dbOptions { get; set; }

            //the variable that will get us the connection string
            private AppConfiguration constring { get; set; }

            public OptionBuild()
            {
                constring = new AppConfiguration();
                opsBuilder = new DbContextOptionsBuilder<DataBaseContext>();
                opsBuilder.UseSqlServer(constring.sqlconnectionString);
                dbOptions = opsBuilder.Options;
            }


        }
        public static OptionBuild ops = new OptionBuild();



        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DefaultPermissions>().HasKey(df => new { df.permissionId, df.roleId });

            modelBuilder.Entity<UserPermission>().HasKey(up => new { up.personId, up.permisionId });

        }


        //adding our classes so that they can become table in the base

        public DbSet<Person> Persons { get; set; }
        public DbSet<Client> Clients { get; set; }

        public DbSet<Agent> Agents { get; set; }

        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions {get;set;}
        public DbSet<DefaultPermissions> DefaultPermissions { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }

        public DbSet<Ticket> Tickets { get; set; }


    }

}
