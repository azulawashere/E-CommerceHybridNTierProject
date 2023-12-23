﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Configurations
{
    public class AppUserConfiguration:BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            builder.Ignore(x=>x.ID);
            builder.HasMany(x=>x.Orders).WithOne(x=>x.AppUser).HasForeignKey(x=>x.AppUserID);
            builder.HasOne(x=>x.Profile).WithOne(x=>x.AppUser).HasForeignKey<AppUserProfile>(x=>x.ID);
        }

    }
}
