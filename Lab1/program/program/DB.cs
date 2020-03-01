using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace ADO.NET
{
    class DB
    {
        public void Select(SqlConnection connection)
        {
            var sql = "SELECT * FROM Region";
            var command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(String.Format($"{reader[0]},{reader[1]}"));
            }
        }
        public void Insert(SqlConnection connection, string regionName, int id)
        {

            var sql = "INSERT INTO Region(RegionID,RegionDescription) VALUES (@id,@regionName)";
            var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@regionName", regionName);

            int affected = command.ExecuteNonQuery();

            Console.WriteLine($"{affected} rows");
        }
        public void Delete(SqlConnection connection, int id)
        {
            var sql = "DELETE FROM Region WHERE RegionID=@id";
            var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);
            int affected = command.ExecuteNonQuery();
            Console.WriteLine($"{affected} rows");
        }
        public void Update(SqlConnection connection, int id, string newRegion)
        {
            var sql = "UPDATE Region SET RegionDescription=@newRegion WHERE RegionId=@id";
            var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@newReg", newRegion);
            int affected = command.ExecuteNonQuery();
            Console.WriteLine($"{affected} rows");
        }


    }
}
