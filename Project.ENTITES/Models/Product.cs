using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITES.Models
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public string ImagePath { get; set; }
        public int CategoryID { get; set; }
        //Relational properties
        public virtual Category  Category{ get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
