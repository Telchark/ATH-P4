using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSES
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ESContext();
            context.Computers.Add(new ESComputer() { Description = "Test Lap", CoolingType = "Air", Weight = 2, Price = 1500 });
            context.SaveChanges();

            var tscontext = new TSContext();
            tscontext.Computers.Add(new TSComputer() 
            { Description = "Test Lap", CoolingType = "Air", Weight = 2, Price = 1500,
                Server = new Server() { Bandwidth = 1000 } });
            tscontext.SaveChanges();
        }
    }
}
