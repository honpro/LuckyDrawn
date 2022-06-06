using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;

namespace ProjectAlta
{
    public static class DbAdd
    {
        public static IServiceCollection ServicesCollection(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<AddContext>(options => options.UseSqlServer(configuration.GetConnectionString("ProjectAlta"),
               x => x.MigrationsAssembly(typeof(AddContext).Assembly.FullName)), ServiceLifetime.Transient);

            return service;
        }
    }
}
