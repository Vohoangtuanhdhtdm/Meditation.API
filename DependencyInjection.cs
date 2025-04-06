using Meditation.Application;
using Meditation.Infrastructure;

namespace Meditation.API
{
    public static class DependencyInjection
    {
        // DI 
        public static IServiceCollection AddAppDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationDI()
                .AddInfrastructureDI(configuration);

            return services;
        }
    }
}
