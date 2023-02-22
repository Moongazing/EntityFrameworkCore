using _22_02_2023_Database_First.DataAccess;
using Microsoft.EntityFrameworkCore;

using (var context = new AppDbContext())
{
  var products = await context.Products.ToListAsync();

  products.ForEach(p =>
  {
    Console.WriteLine($"{p.Id}-{p.Name}-{p.Price}");
  });
  /*
  foreach (var product in products)
  {
    Console.WriteLine($"{product.Id}-{product.Name}-{product.Price}");
  }*/
}