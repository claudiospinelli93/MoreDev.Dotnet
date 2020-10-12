using Microsoft.Extensions.DependencyInjection;
using MoreDev.Domain.Interfaces.Repository;
using MoreDev.Infra.Data.SqlServer.Repository;

namespace MoreDev.Service.DependecyInjection.RepositoryInjection
{
    class ConfigureBindingsRepository
    {
        public static void RegisterBindings(IServiceCollection services)
        {
            services.AddScoped<IHelloMoreDevRepository, HelloMoreDevRepository>();
        }
    }
}
