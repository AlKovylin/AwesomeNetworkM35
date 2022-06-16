﻿using AwesomeNetworkM35.Data.Repository;
using AwesomeNetworkM35.Data.UoW;
using Microsoft.Extensions.DependencyInjection;

namespace AwesomeNetworkM35.Extenstions
{
    public static class ServiceExtentions
    {
        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }

        public static IServiceCollection AddCustomRepository<TEntity, IRepository>(this IServiceCollection services)
                 where TEntity : class
                 where IRepository : class, IRepository<TEntity>
        {
            services.AddScoped<IRepository<TEntity>, IRepository>();

            return services;
        }

    }
}

