using MapDemo.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MapDemo.DataAccess
{
    public class MapDemoDbContext : DbContext
    {
        public MapDemoDbContext():base("MapDemoDb")
        {

        }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Armor> Armors { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Castle> Castles { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
