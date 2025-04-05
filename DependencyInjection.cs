using Meditation.Application;
using Meditation.Infrastructure;

namespace Meditation.API
{
    public static class DependencyInjection
    {
        // DI 
        public static IServiceCollection AddAppDI(this IServiceCollection services)
        {
            services.AddApplicationDI()
                .AddInfrastructureDI();

            return services;
        }
    }
}
