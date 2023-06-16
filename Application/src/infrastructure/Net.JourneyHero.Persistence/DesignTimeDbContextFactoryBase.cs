using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Net.JourneyHero.Persistence
{
    public abstract class DesignTimeDbContextFactoryBase<TContext> :
        IDesignTimeDbContextFactory<TContext> where TContext : DbContext
    {
        private const string ConnectionStringName = "Default";
        private const string AspNetCoreEnvironment = "ASPNETCORE_ENVIRONMENT";

        public TContext CreateDbContext(string[] args)
        {
            var basePath = Assembly.GetExecutingAssembly().Location;
            return Create(basePath, Environment.GetEnvironmentVariable(AspNetCoreEnvironment) ?? "Local");
        }

        protected abstract TContext CreateNewInstance(DbContextOptions<TContext> options);

        private TContext Create(string basePath, string environmentName)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.Local.json", optional: true)
                .AddJsonFile($"appsettings.{environmentName}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            var connectionString = configuration.GetConnectionString(ConnectionStringName) ??
                                   throw new NullReferenceException("connection string is null");

            return Create(connectionString);
        }

        private TContext Create(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException($"Connection string '{ConnectionStringName}' is null or empty.",
                    nameof(connectionString));
            }

            Console.WriteLine(
                $"DesignTimeDbContextFactoryBase.Create(string): Connection string: '{connectionString}'.");

            var optionsBuilder = new DbContextOptionsBuilder<TContext>();

            optionsBuilder.UseMySQL(connectionString);
            optionsBuilder.EnableDetailedErrors();

            return CreateNewInstance(optionsBuilder.Options);
        }
    }
}