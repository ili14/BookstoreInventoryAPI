using System;

namespace BookstoreInventoryAPI.Presentation;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // services.AddAutoMapper(typeof(MappingProfile));
        // services.AddValidatorsFromAssemblyContaining<ProductDtoValidator>();
        // services.AddScoped<IProductService, ProductService>();
        return services;
    }
}
