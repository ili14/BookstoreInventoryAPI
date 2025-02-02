

using Microsoft.Extensions.DependencyInjection;

namespace Application // <- Namespace of the Application layer
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // Register services, validators, etc.
            // services.AddScoped<IProductService, ProductService>();
            // services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);
            return services;
        }
    }
}