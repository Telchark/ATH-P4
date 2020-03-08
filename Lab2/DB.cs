using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dapper;

namespace Lab2
{
    class DB
    {
        public void SelectOrder(IDbConnection connection, int id)
        {
            var sql = "SELECT * FROM Orders O JOIN [Order Details] OD ON O.OrderID=OD.OrderID WHERE O.OrderID=@id";

            var resultOrder = default(Order); 

            var result = connection.Query<Order, OrderDetails, Order>(//<typ numer 1, typ numer 2, return>
                sql,
                (order, orderDetails) => 
                {
                    resultOrder ??= order; //jezeli jest nullerm to zrob
                                           //if (resultOrder==null)
                                           //{
                                           //    resultOrder = order;
                                           //}

                    resultOrder.Details.Add(orderDetails);
                    return resultOrder;
                },
                new { id },
                splitOn: "OrderID"//object params 
                );
        }
        public void SelectRegion(IDbConnection connection)
        {
            var selectSql = "SELECT * FROM Region";
            var result = connection.Query<Region>(selectSql);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.RegionID},{item.RegionDescription}");
            }
        }

        public int InsertRegion(IDbConnection connection, Region region)
        {
            var insertSql = "INSERT INTO Region(RegionID,RegionDescription) VALUES (@RegionID,@RegionDescription)";
            return connection.Execute(insertSql, region);
        }
        public int InsertRegion(IDbConnection connection, int RegionID, string RegionDescription)
        {
            var insertSql = "INSERT INTO Region(RegionID,RegionDescription) VALUES (@RegionID,@RegionDescription)";
            return connection.Execute(insertSql, new { RegionID = RegionID, RegionDescription = RegionDescription});
        }
        public int DeleteRegion(IDbConnection connection, int id)
        {
            var deleteSql = "DELETE FROM Region WHERE RegionID=@RegionID";
            return connection.Execute(deleteSql,new { RegionID = id });
        }
    }
}
