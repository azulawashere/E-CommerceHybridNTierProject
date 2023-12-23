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
    public class AppUserManager : BaseManager<AppUserDTO, AppUser>, IAppUserManager
    {
        // ! Liskov's Substitution

        IAppUserRepository _appRep;
        public AppUserManager(IAppUserRepository appRep, IMapper mapper) : base(appRep, mapper)
        {
            _appRep = appRep;

        }

        public async Task<bool> AddUser(AppUser item)
        {

            return await _appRep.AddUser(item);
        }
    }
}
