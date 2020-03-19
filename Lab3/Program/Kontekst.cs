using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Program
{
    public class Kontekst : DbContext
    {
        public  DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);     
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Programowanie;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Student>()
        //        .Property(x => x.Imie)
        //        .HasMaxLength(255)
        //        .HasDefaultValue("asd");

        //    modelBuilder.Entity<Student>()
        //        .Property(x => x.Nazwisko)
        //        .HasMaxLength(255);
        //}
    }
}
