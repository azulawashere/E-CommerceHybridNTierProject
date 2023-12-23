using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTOClasses
{
    public class ProductDTO : BaseDTO
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int? CategoryID { get; set; }
        public int UnitsInStock { get; set; }
        public string ImagePath { get; set; }
        public CategoryDTO  Category { get; set; }
    }
}
