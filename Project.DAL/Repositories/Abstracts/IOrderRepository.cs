using Project.DAL.Repositories.Concretes;
using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Abstracts
{
    public interface IOrderRepository:IRepository<Order>
    {
        public Task<int> AddAndGetID(Order order);
    }
}
