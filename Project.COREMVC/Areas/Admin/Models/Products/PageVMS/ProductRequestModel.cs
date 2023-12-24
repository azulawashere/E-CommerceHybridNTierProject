namespace Project.COREMVC.Areas.Admin.Models.Products.PageVMS
{
    public class ProductRequestModel
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public string ImagePath { get; set; }
        public int CategoryID { get; set; }
    }
}
