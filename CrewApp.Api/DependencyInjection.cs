using CrewApp.Application;
using CrewApp.Infrastructure;
using CrewApp.Domain;

namespace CrewApp.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationDI()
                    .AddInfrastructureDI()
                    .AddDomainDI(configuration);
            return services;
        }
    }
}
