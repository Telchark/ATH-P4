using System;
using System.Data.SqlClient;
namespace ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            var db = new DB();
            db.Select(connection);
            //db.Insert(connection, "Bielsko", 5);
            //db.Delete(connection, 11);
            //db.Update(connection, 5, "Bielsko-Biała");
            connection.Close(); //optional
        }
    }
}