using AutoMapper;
using Project.BLL.DTOClasses;
using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Concretes
{
    public class OrderManager : BaseManager<OrderDTO, Order>, IOrderManager
    {
        IOrderRepository _oRep;
        IMapper _mapper;
        public OrderManager(IOrderRepository oRep, IMapper mapper) : base(oRep, mapper)
        {
            _oRep = oRep;
            _mapper = mapper;
        }

        public Task<int> AddAndGetID(OrderDTO orderDTO)
        {

            return _oRep.AddAndGetID(_mapper.Map<Order>(orderDTO));
        }
    }
}
