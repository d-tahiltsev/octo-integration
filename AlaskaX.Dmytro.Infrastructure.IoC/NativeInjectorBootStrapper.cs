using AlaskaX.Dmytro.Adapter.Octo_Travel;
using AlaskaX.Dmytro.Application.Services;
using AlaskaX.Dmytro.Domain.Interfaces.Repositories;
using AlaskaX.Dmytro.Domain.Interfaces.Services;
using AlaskaX.Dmytro.Infrastructure.Data.Repositories;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AlaskaX.Dmytro.Infrastructure.IoC
{
    /// <summary>
    /// A Native bootstrapper allows us to connect multiple APIs projects to the internal layers.
    /// </summary>
    /// <remarks>
    /// For each API, it's possible to load the same bootsrapper injection or, if necessary,
    /// create different injection strategy to different API's, sharing the same or particular layers. 
    /// </remarks>
    public class NativeInjectorBootStrapper
    {
        public static void ResolveDatabase(IConfiguration configuration, IServiceCollection services)
        {
        }

        public static void ResolveRepositories(IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
        }

        public static void ResolveServices(IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<ISupplierService, SupplierService>();
            services.AddScoped<IProductService, ProductService>();
        }

        public static void ResolveAdapters(IServiceCollection services)
        {
            services.AddScoped<IOctoTravelApi, OctoTravelApi>();
        }
    }
}
