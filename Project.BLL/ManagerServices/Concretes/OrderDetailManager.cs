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
    public class OrderDetailManager : BaseManager<OrderDetailDTO, OrderDetail>, IOrderDetailManager
    {

        IOrderDetailRepository _odRep;
        public OrderDetailManager(IOrderDetailRepository odRep, IMapper mapper) : base(odRep, mapper)
        {
            _odRep = odRep;
        }
    }
}
