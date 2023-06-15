﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Net.JourneyHero.Application.Common.Interfaces;
using Northwind.Persistence;

namespace Net.JourneyHero.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<JourneyHeroDbContext>(options =>
                options.UseMySQL(configuration.GetConnectionString("Default") ?? throw new NullReferenceException("Connection string is null")));

            services.AddScoped<IJourneyHeroDbContext>(provider => provider.GetService<JourneyHeroDbContext>());

            return services;
        }
    }
}
