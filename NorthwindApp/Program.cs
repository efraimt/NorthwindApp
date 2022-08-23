
using NorthwindApp;
using NorthwindApp.Models;

new EF_Lesson_2().RunClassCode();

//var db = new NorthwindContext();

////We have defined a Query
//var categoriesQuery = db.Categories.OrderByDescending(c=>c.CategoryName);

////We are executint the query
//var list = categoriesQuery.ToList();    

////We are executint the query
//foreach (var item in categoriesQuery)
//{
//    Console.WriteLine(item.CategoryName);
//}

////We are executint the query
//var firstCategory = db.Categories.First();

////We defin a query and the foreach makes it to excute
//foreach (var item in db.Products)
//{
//    Console.WriteLine(item.ProductName);
//}


//var productsOfCategory8 = db.Products.Where(p => p.CategoryId == 8).ToList();

//Console.WriteLine(productsOfCategory8);

///*
// Insertions
// */
//var region = new Region() { RegionId = 5, RegionDescription = "Israel" };
////db.Regions.Add(region);

////Just now we execute the sql insert against the DB
//db.SaveChanges();



////Update
//list[0].Description += " 1";
//db.SaveChanges();

////Delete
//db.Regions.Remove(region);
//db.SaveChanges();

//var regions = db.Regions;
//var ters = db.Territories.ToList();
//foreach (var region1 in db.Regions)
//{
//    Console.WriteLine(region1.RegionDescription);
//    foreach (var ter in region1.Territories)
//    {
//        Console.WriteLine("  -"+ter.TerritoryDescription);
//    }
//}

//var order = new Order()
//{
//    EmployeeId = 6,
//    CustomerId = "FRANK",
//    OrderDate = new DateTime(2022, 08, 02),
//    ShipAddress = "7 Picadily Rd.",
//    ShipCity = "New York",
//    ShipCountry = "New York",
//    OrderDetails = new List<OrderDetail>
//    {
//        new OrderDetail() { ProductId = 11, UnitPrice = 95, Quantity = 3 },
//        new OrderDetail() { ProductId = 56, UnitPrice = 47, Quantity = 6 },
//        new OrderDetail() { ProductId = 74, UnitPrice = 120, Quantity = 5 }
//    }
//};

//db.Orders.Add(order);

//db.SaveChanges();

//Console.WriteLine(order.OrderId);

