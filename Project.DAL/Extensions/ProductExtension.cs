using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Extensions
{
    public static class ProductExtension
    {
        public static void SeedProducts(ModelBuilder modelBuilder)
        {
            List<Product> products = new();
            for (int i = 1;i < 10; i++)
            {
                Product p = new()
                {
                    ID = i,
                    ProductName = new Commerce("tr").ProductName(),
                    UnitPrice = Convert.ToDecimal(new Commerce("tr").Price()),
                    UnitInStock = 100,
                    CategoryID = i,
                    ImagePath = "/images/TheWarrior.jpg"
                };
                products.Add(p);
                modelBuilder.Entity<Product>().HasData(p);
            }
        }
    }
}
