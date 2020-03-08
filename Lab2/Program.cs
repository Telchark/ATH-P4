using System;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            var db = new DB();
            //db.SelectOrder(connection,10248);
            db.SelectRegion(connection);
            //var region = new Region() { RegionDescription = "Dapper1", RegionID = 666 };
            //db.Insert(connection,region);
            //db.Insert(connection, 55, "ASD");
            //db.Delete(connection, 100);
            //db.Update(connection, 5, "Bielsko-Biała");
        }
    }
}