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
    public class CategoryManager : BaseManager<CategoryDTO, Category>, ICategoryManager
    {
        ICategoryRepository _catRep;
        public CategoryManager(ICategoryRepository catRep, IMapper mapper) : base(catRep, mapper)
        {
            _catRep = catRep;
        }
    }
}
