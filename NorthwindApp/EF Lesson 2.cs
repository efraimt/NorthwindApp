using Microsoft.EntityFrameworkCore;
using NorthwindApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindApp
{
    internal class EF_Lesson_2
    {
        NorthwindContext db = new NorthwindContext();
        public void RunClassCode()
        {

            ////Fetch all categories
            //var catQuery = (from cat in db.Categories
            //                where cat.CategoryId > 4
            //                select new { cat.CategoryName, cat.CategoryId });

            //var catQuery2 = db.Categories.Where(x => x.CategoryId > 4).Count();

            //var catList = catQuery.ToList().Count();

            ////foreach (var item in catList)
            ////{
            ////    Console.WriteLine(item.CategoryName);
            ////}

            ////foreach (var item in catQuery2)
            ////{
            ////    Console.WriteLine(item.CategoryName);

            ////}

            ////Create : 1. Create the new object, 2. Add it to the context, 3. SaveChanges
            //var teritorry = new Territory() { TerritoryId = "IL2", TerritoryDescription = "Israel2", RegionId = 1 };
            //db.Territories.Add(teritorry);


            //db.SaveChanges();


            //foreach (var item in db.Territories)
            //{
            //    Console.WriteLine(item.TerritoryDescription);
            //}


            //teritorry.TerritoryDescription = "Big Israel";
            //db.SaveChanges();

            //foreach (var item in db.Territories)
            //{
            //    Console.WriteLine(item.TerritoryDescription);
            //}

            var tempList = db.Territories.Where(x => x.TerritoryId.StartsWith("IL"));
            foreach (var item in tempList)
            {
                db.Remove(item);
            }

            //db.SaveChanges();

            /*
             1. לשלוף את כל המוצרים של קטגוריה מס' 4

             2. שנית, לשלוף את כל המוצרים של קטגוריות עם מזהה מעל 4

            3. נשלוף את כל המוצרים במערכת, נשלוף שם מוצר ושם קטגוריה בלבד

            4. Add region and save it

            5. Change the name of the new region

            6. Delete the added region
             */

            /*----------------------   JOIN ----------------------------------*/


            var order1 = db.Orders.Find(10250);


            //Explicit
            order1.Customer = db.Customers.Find(order1.CustomerId);
            order1.OrderDetails = db.OrderDetails.Where(od => od.OrderId == order1.OrderId).ToList();

            //Eager Loading
            var order2 = db.Orders.Where(o => o.OrderId == 10250)
                .Include(o => o.Customer)
                .Include(o => o.Employee)
                .Include(o => o.OrderDetails).First();


            //Lazy Loding
            var order3 = db.Orders.Where(o => o.OrderId == 10250).FirstOrDefault();
            Console.WriteLine(order3.Customer.CompanyName);

        }
    }
}
