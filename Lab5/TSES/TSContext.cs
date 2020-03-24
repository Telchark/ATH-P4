using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSES
{
    public class TSContext : DbContext
    {
        public DbSet<TSComputer> Computers { get; set; }
        public DbSet<Server> Servers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TSComputer>()
                .HasRequired(e => e.Server)
                .WithRequiredDependent(e => e.Computer);
        }

    }
}
