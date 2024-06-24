using AuthenticationStudie.Controllers.Service;
using AuthenticationStudie.Entity;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationStudie
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureApi(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OurHeroDbContext>(options =>
            options.UseSqlServer(configuration["ConnectionStrings:OurHeroConnectionString"])
            );

            services.AddTransient<IOurHeroService, OurHeroService>();

            return services;
        }

        public static IServiceCollection AddOptionsApi(this IServiceCollection service, IConfiguration configuration)
        {
            //service.Configure<StorageAccountOptions>(options =>
            //{
            //    options.ConexaoSqlServer = configuration["ConexaoSqlServer"];
            //});

            return service;
        }
    }
}
