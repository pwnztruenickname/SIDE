using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace SIDE.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDbContext(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<DataContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            return service;
        }
    }
}