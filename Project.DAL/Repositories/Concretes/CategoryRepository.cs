using Project.DAL.ContextClasses;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Concretes
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(MyContext db):base(db) 
        {
            
        }

        public void SpeacialCategoryCreation(Category category,params string[] productName)
        {
            List<Product> products = new();
            foreach(string product in productName)
            {
                Product p = new Product()
                {
                    ProductName = product,
                    UnitPrice = 1.2m
                };
                products.Add(p);
            }
            category.Products = products;
            Add(category);
        }
    }
}
