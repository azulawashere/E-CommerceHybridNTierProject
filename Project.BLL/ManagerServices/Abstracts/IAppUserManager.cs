using Project.BLL.DTOClasses;
using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Abstracts
{
    public interface IAppUserManager:IManager<AppUserDTO, AppUser>
    {
        Task<bool> AddUser(AppUser user);
    }
}
