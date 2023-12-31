﻿using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Net.JourneyHero.Application.Common.Behaviours;

namespace Net.JourneyHero.Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(configuration =>
                configuration.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
        }
    }
}