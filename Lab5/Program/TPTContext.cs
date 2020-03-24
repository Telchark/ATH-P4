using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class TPTContext : DbContext
    {
        public DbSet<Computer> Computers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PC>().ToTable("Pecety");
            modelBuilder.Entity<Laptop>().ToTable("Laptopty");
        }xxx
    }
}
