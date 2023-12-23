using Project.ENTITES.Enums;

namespace Project.COREMVC.Areas.Admin.Models.Categories.ResponseModels
{
    public class CategoryResponseModel
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public DataStatus   Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
