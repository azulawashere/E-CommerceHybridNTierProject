using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTOClasses
{
    public class OrderDetailDTO : BaseDTO
    {
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set; }
    }
}
