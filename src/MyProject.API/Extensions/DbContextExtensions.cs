using Microsoft.EntityFrameworkCore;
using MyProject.Infrastructure.Data;

namespace MyProject.Api.Extensions;

public static class DbContextExtensions
{
    public static void AddDbContextConfig(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
    }
}