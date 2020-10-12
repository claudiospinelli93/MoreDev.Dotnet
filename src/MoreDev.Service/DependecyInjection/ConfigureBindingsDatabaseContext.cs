using Estudo.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MoreDev.Infra.Data.SqlServer.Context;

namespace MoreDev.Service.DependecyInjection
{
    public class ConfigureBindingsDatabaseContext
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            //SQL SERVER
            services
                .AddEntityFrameworkSqlServer()
                .AddDbContext<MoreDevContext>(
                    options => options.UseSqlServer(configuration.GetConnectionString("apiServer"))
                );

            services
                .AddEntityFrameworkSqlServer()
                .AddDbContext<EstudoContext>(
                    options => options.UseSqlServer(configuration.GetConnectionString("apiServer"))
                );
        }
    }
}
