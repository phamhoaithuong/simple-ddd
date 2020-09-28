using AutoMapper;
using Ecommerce.Domain.Entity;
using Ecommerce.Domain.Mapper;
using Ecommerce.Infrastructure.Repository;
using Ecommerce.Infrastructure.UnitOfWork;
using Ecommerce.Service.OrderService;
using Ecommerce.Service.Productervice;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Ecommerce.DI
{
    public static class EcommerceBootstrap
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain
            // Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<DbContext, EcommerceContext>();

            // Infrastructure            
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Service
            services.AddScoped<IProductervice, Productervice>();

            services.AddScoped<IOrderService, OrderService>();


        }
    }
}

