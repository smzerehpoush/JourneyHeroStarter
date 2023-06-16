using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Net.JourneyHero.Application;
using Serilog;
using ILogger = Serilog.ILogger;

namespace Net.JourneyHero.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddSerilog(new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .CreateLogger());
            var serviceProvider = services.BuildServiceProvider();
            var logger = serviceProvider.GetRequiredService<ILogger<IApplication>>();
            services.AddSingleton(typeof(ILogger), logger);
        }
    }
}