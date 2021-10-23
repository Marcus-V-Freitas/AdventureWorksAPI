using Application.Mappings;
using Application.Services.Interfaces;
using Application.Services.Repository;
using Data.Context;
using Data.Repository;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IoC.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //AutoMapper
            services.AddAutoMapper(typeof(DomainMappingProfile));

            //Database
            string mySqlConnectionStr = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContextPool<AdventureWorksContext>(options => options.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr)));

            //Repositories
            services.AddScoped<IProductRepository, ProductRepository>();

            //Services
            services.AddScoped<IProductService, ProductService>();
            return services;
        }
    }
}