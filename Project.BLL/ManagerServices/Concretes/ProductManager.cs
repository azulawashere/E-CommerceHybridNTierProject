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
    public class ProductManager : BaseManager<ProductDTO, Product>, IProductManager
    {
        IProductRepository _pRep;
        public ProductManager(IProductRepository pRep, IMapper mapper) : base(pRep, mapper)
        {
            _pRep = pRep;
        }
    }
}
