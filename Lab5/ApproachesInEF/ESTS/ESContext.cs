using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSES
{
    class ESContext : DbContext
    {
        public DbSet<ESComputer> Computers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ESComputer>().Map(map =>
            {
                map.Properties(prop => new
                {
                    prop.CoolingType,
                    prop.Description
                });
                map.ToTable("PolaTekstowe");
            })
            .Map(map =>
            {
                map.Properties(prop => new
                {
                    prop.Id,
                    prop.Price,
                    prop.Weight
                });
                map.ToTable("PolaLiczbowe");
            });

        }
    }
}
