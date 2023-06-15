using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Net.JourneyHero.Application;
using Net.JourneyHero.Application.Common.Interfaces;
using Net.JourneyHero.Infrastructure;
using Net.JourneyHero.Persistence;
using Net.JourneyHero.WebApi.Middlewares;
using Net.JourneyHero.WebApi.Services;

namespace Net.JourneyHero.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddInfrastructure();
            services.AddPersistence(Configuration);
            services.AddApplication();

            services.AddHealthChecks().AddDbContextCheck<JourneyHeroDbContext>();

            services.AddScoped<ICurrentUserService, CurrentUserService>();

            services.AddHttpContextAccessor();

            services.AddValidatorsFromAssemblyContaining<IApplication>();

            services
                .AddControllersWithViews()
                .AddNewtonsoftJson();

            services.Configure<ApiBehaviorOptions>(options => { options.SuppressModelStateInvalidFilter = true; });

            services.AddOpenApiDocument(configure => { configure.Title = "Journey Hero API"; });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseCustomExceptionHandler();
            app.UseHealthChecks("/health");
            app.UseHttpsRedirection();
            app.UseOpenApi();

            app.UseSwaggerUi3();
            app.UseRouting();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}