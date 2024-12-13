using AlaskaX.Dmytro.Adapter.Octo_Travel;

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
        }

        public static void ResolveServices(IServiceCollection services)
        {
        }

        public static void ResolveAdapters(IServiceCollection services)
        {
            services.AddScoped<IOctoTravelApi, OctoTravelApi>();
        }
    }
}
