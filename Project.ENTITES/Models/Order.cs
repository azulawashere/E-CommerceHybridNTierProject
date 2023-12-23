using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITES.Models
{
    public class Order:BaseEntity
    {
        public string ShippingAddress { get; set; }//Kullanıcının Talep ettiği adres.
        public string Email { get; set; }//Üye olmayan bir kullanıcının email'i özel olarak burada tutulur. Null geçildiyse anlayın ki kullanıcı üye olara alışveriş yapmıştır.
        public string NameDescription { get; set; }//Üye olmayan bir kullanıcının isima açıklaması.
        public int? AppUserID { get; set; }// null gecilebiliyorsa anlayın ki kullanıcı üye değildir

        public decimal PriceOfOrder { get; set; }

        //Relational Properties
        public  virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual AppUser AppUser  { get; set; }
    }
}
