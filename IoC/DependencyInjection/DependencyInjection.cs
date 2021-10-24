using Application.Mappings;
using Application.Services.Interfaces;
using Application.Services.Repository;
using Data.Context;

using Data.Repository;
using Domain.Interfaces;
using IoC.Middlewares;
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
            services.AddDbContextPool<AdventureWorksContext>(options =>
            {
                options.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr));
            });

            //Exceptions
            services.AddTransient<GlobalExceptionHandlerMiddleware>();

            //Repositories
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            //Services
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IEmployeeService, EmployeeService>();

            //Health Check
            services.AddHealthChecks()
                .AddCheck<ProductRepository>(nameof(ProductRepository))
                .AddCheck<EmployeeRepository>(nameof(EmployeeRepository));

            return services;
        }
    }
}