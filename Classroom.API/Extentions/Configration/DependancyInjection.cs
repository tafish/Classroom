﻿using Classroom.API.Application.Repository.Interface;
using Classroom.API.Infrastructure.Presistance.Ropository;
using MovieSystem.Infrastructure.Presistance.Repository;

namespace Classroom.API.Extentions.Configration
{
    public static class DependancyInjection 
    {
        public static IServiceCollection CustomConfigrationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}

