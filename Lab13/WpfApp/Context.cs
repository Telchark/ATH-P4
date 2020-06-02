using System.Data.Entity;

namespace WpfApp
{
    public class Context : DbContext
    {
        public DbSet<Model> Models { get; set; }
        public Context()
        {

            Models.Add(new Model() { Amount = 5, Text = "test" });

        }
    }
}
