using Project.DAL.ContextClasses;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Concretes
{
    public class OrderRepository:BaseRepository<Order>,IOrderRepository
    {
        public OrderRepository(MyContext db) : base(db)
        {
            
        }

        public async Task<int> AddAndGetID(Order order)
        {
          await _db.Orders.AddAsync(order);
          _db.SaveChanges();
            return order.ID;
        }
    }
}
