using Microsoft.OpenApi.Models;
using MyProject.Application.Interfaces;
using MyProject.Application.Services;
using MyProject.Domain.Interfaces;
using MyProject.Infrastructure.Repositories;

public static class ServiceExtensions
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        // Registros de DI
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IProductRepository, ProductRepository>();
    }

    public static void AddSwaggerConfig(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo 
            { 
                Title = "MyProject API", 
                Version = "v1",
                Description = "API Documentation"
            });
        });
    }
}