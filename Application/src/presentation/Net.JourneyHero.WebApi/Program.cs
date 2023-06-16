using MediatR;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Net.JourneyHero.Persistence;

namespace Net.JourneyHero.WebApi
{
    public class Program
    {
        private const string AspNetCoreEnvironment = "ASPNETCORE_ENVIRONMENT";

        public static async Task Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var northwindContext = services.GetRequiredService<JourneyHeroDbContext>();
                    await northwindContext.Database.MigrateAsync();

                    var mediator = services.GetRequiredService<IMediator>();
                    // await mediator.Send(new SeedSampleDataCommand(), CancellationToken.None);
                }
                catch (Exception ex)
                {
                    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while migrating or initializing the database");
                }
            }

            await host.RunAsync();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            var environment = Environment.GetEnvironmentVariable(AspNetCoreEnvironment) ?? "Local";
            return WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    var env = hostingContext.HostingEnvironment;

                    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                        .AddJsonFile($"appsettings.Local.json", optional: true, reloadOnChange: true);

                    config.AddEnvironmentVariables();
                })
                .UseEnvironment(environment)
                .UseStartup<Startup>();
        }
    }
}