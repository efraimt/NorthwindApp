
using NorthwindApp;
using NorthwindApp.Models;

var db = new NorthwindContext();

//We have defined a Query
var categoriesQuery = db.Categories.OrderByDescending(c=>c.CategoryName);

//We are executint the query
var list = categoriesQuery.ToList();    

//We are executint the query
foreach (var item in categoriesQuery)
{
    Console.WriteLine(item.CategoryName);
}

//We are executint the query
var firstCategory = db.Categories.First();

//We defin a query and the foreach makes it to excute
foreach (var item in db.Products)
{
    Console.WriteLine(item.ProductName);
}


var productsOfCategory8 = db.Products.Where(p => p.CategoryId == 8).ToList();

Console.WriteLine(productsOfCategory8);

/*
 Insertions
 */
var region = new Region() { RegionId = 5, RegionDescription = "Israel" };
//db.Regions.Add(region);

//Just now we execute the sql insert against the DB
db.SaveChanges();



//Update
list[0].Description += " 1";
db.SaveChanges();

//Delete
db.Regions.Remove(region);
db.SaveChanges();

