﻿using Microsoft.AspNetCore.Identity;
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
    public class AppUserRepository : BaseRepository<AppUser>, IAppUserRepository
    {
        UserManager<AppUser> _userManager;

        public AppUserRepository(MyContext db, UserManager<AppUser> userManager) : base(db)
        {
            _userManager = userManager;
        }

        public async Task<bool> AddUser(AppUser user)
        {
            //AppUser yerine UserRegisterRequestModel kullanın
            IdentityResult result = await _userManager.CreateAsync(user, user.PasswordHash);
            if (result.Succeeded) return true;
            return false;

        }
    }
}
