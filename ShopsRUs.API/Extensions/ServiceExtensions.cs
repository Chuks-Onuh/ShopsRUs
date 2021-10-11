using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShopsRUs.Infrastructure.Contracts.Interface;
using ShopsRUs.Infrastructure.DBContext;
using ShopsRUs.Infrastructure.LoggerService;
using Sterling.Fusion.Community.Infrastructure.DataAccess.Repository;

namespace ShopsRUs.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureLoggerService(this IServiceCollection services) =>
           services.AddScoped<ILoggerManager, LoggerManager>();

        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder.WithOrigins("")
                .AllowAnyHeader()
                .WithMethods("POST", "GET", "PUT", "DELETE", "PATCH")
                .AllowCredentials()
                .Build());
            });
            

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));
        }

        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }
    }
}
