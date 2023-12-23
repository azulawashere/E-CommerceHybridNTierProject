﻿using Microsoft.Extensions.DependencyInjection;
using Project.DAL.Repositories.Abstracts;
using Project.DAL.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ServiceInjections
{
    public static class RepositoryService
    {
        public static IServiceCollection AddRepServices(this IServiceCollection services)
        {

            services.AddScoped(typeof(IRepository<>),typeof(BaseRepository<>));
            services.AddScoped<IProductRepository,ProductRepository>();
            services.AddScoped<IOrderRepository,OrderRepository>();
            services.AddScoped<IOrderDetailRepository,OrderDetailRepository>();
            services.AddScoped<ICategoryRepository,CategoryRepository>();
            services.AddScoped<IProfileRepository,ProfileRepository>();
            services.AddScoped<IAppUserRepository,AppUserRepository>();
           return services;
        }
    }
}
