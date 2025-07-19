using Contracts;
using Contracts.Repo;
using Contracts.Service;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using Repository.context;
using Repository.Repos;
using Services;

namespace saccoshop.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
 services.AddCors(options =>
 {
     options.AddPolicy("CorsPolicy", builder =>
     builder.AllowAnyOrigin()
     .AllowAnyMethod()
     .AllowAnyHeader().WithExposedHeaders("X-Pagination"));

 });


        public static void ConfigureIISIntegration(this IServiceCollection services) =>
     services.Configure<IISOptions>(options =>
     {
     });
        public static void ConfigureLoggerService(this IServiceCollection services) => services.AddSingleton<ILoggerManager, LoggerManager>();
        public static void ConfigureRepositoryManager(this IServiceCollection services) => services.AddScoped<IRepositoryManager, RepositoryManager>();
        public static void ConfigureServiceManager(this IServiceCollection services) =>services.AddScoped<IServiceManager, ServiceManager>();
        //        public static void ConfigureSqlContext(this IServiceCollection services,
        //IConfiguration configuration) =>services.AddDbContext<ApplicationDbContext>(opts =>opts.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>services.AddDbContext<ApplicationDbContext>(opts =>opts.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        //public static void ConfigureSqlContext1(this IServiceCollection services,  IConfiguration configuration) => services.AddSqlServer<ApplicationDbContext>((configuration.GetConnectionString("DefaultConnection")));

    }
}