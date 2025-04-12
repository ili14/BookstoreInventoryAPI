using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookstoreInventoryAPI.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services, IConfiguration configuration)
    {
        // services.AddDbContext<>(options =>
        //     options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        // services.AddScoped<IProductRepository, ProductRepository>();
        return services;
    }
}
