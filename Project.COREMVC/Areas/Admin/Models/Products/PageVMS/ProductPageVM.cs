using Project.ENTITES.Models;

namespace Project.COREMVC.Areas.Admin.Models.Products.PageVMS
{
    public class ProductPageVM
    {
        public List<Product>   Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
