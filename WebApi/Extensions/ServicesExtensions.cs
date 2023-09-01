using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.EFcore;

namespace WebApi.Extensions
{
    public static class ServicesExtensions
    {
        //sql bağlama konfigurasyonu
        public static void ConfigureSqlContext(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(
                options => options.UseSqlServer(
                    configuration.GetConnectionString("sqlConnection"),
                    optionsBuilder => optionsBuilder.MigrationsAssembly("WebApi")
                    )
                );
        }

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();
    }
}
