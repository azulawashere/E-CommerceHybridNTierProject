using Project.ENTITES.Models;
using X.PagedList;

namespace Project.COREMVC.Models.PageVms
{
    public class ShoppingPageVM
    {
        public IPagedList<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
