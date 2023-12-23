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
    public class ProfileManager : BaseManager<UserProfileDTO, AppUserProfile>, IProfileManager
    {
        IProfileRepository _proRep;
        public ProfileManager(IProfileRepository proRep, IMapper mapper) : base(proRep, mapper)
        {
            _proRep = proRep;


        }
    }
}
