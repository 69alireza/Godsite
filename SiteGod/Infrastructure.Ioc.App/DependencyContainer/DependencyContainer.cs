using Application.App.Interfaces;
using Application.App.Services;
using Domain.App.Interfaces;
using Infrastructure.Data.App.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Ioc.App.DependencyContainer
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ImainService, mainService>();

            //Infrastructure.Data.App Layer
        
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
           

            // Add Memory cache
            services.AddMemoryCache();
        }
    }
}
