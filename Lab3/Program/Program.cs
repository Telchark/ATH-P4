using Microsoft.EntityFrameworkCore;
using Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            using var bazaStudent = new Kontekst();
            using var bazaNorthwind = new NorthwindContext();
            //bazaStudent.Database.EnsureCreated();
            //baza.Students.Add(new Student() { Imie = "Andrzej", Nazwisko = "Boba" });
            //bazaStudent.SaveChanges();

            var studenci = bazaStudent.Students.Where(x => x.Nazwisko == "Boba")
                .ToArray();

            foreach (var student in studenci)
            {
                Console.WriteLine($"{student.Id}. {student.Imie} {student.Nazwisko}");
            }
            var custId = "VINET";
            var orderCust = bazaNorthwind.Orders
                .Where(n => n.CustomerId == custId);

            foreach ( var order  in orderCust)
            {
                Console.WriteLine($"OrderID = {order.OrderId} OrderDate = {order.OrderDate} RequiredDate = {order.RequiredDate}");
            }

            // var q1 = baza.Orders.Where(n=> n.CustomerId == temp)
            //orders orderdetails 
            //var student1 = baza.Students.Where(x => x.Id == 2).First();
            //student1.Imie = "Morganek";
            //baza.Students.Update(student1);
            //baza.SaveChanges();
            //baza.Remove(student1);
            //baza.SaveChanges();
        }
    }
}
