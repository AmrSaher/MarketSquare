using Cortex.Mediator.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MarketSquare.API.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCortexMediator(configuration, new[] { typeof(DependencyInjection) });

            return services;
        }
    }
}
