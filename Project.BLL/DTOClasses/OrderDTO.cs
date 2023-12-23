using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTOClasses
{
    public class OrderDTO : BaseDTO
    {
        public string ShippedAddress { get; set; }
        public int? AppUserID { get; set; }
        public decimal PriceOfOrder { get; set; }
        public string? Email { get; set; }
        public string? NameDescription { get; set; }
    }
}
