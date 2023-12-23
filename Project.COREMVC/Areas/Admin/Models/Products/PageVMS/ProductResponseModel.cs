using Project.ENTITES.Enums;
using Project.ENTITES.Models;

namespace Project.COREMVC.Areas.Admin.Models.Products.PageVMS
{
    public class ProductResponseModel
    {
        public int  ID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public DataStatus Status { get; set; }
        public int CategoryID { get; set; }
    }
}
