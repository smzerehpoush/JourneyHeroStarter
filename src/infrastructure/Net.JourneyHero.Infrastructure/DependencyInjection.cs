using System.Security.Claims;
using Microsoft.Extensions.DependencyInjection;

namespace Net.JourneyHero.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            return services;
        }
    }
}
