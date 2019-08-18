using Microsoft.Extensions.DependencyInjection;
using SingleResponsibilityPrinciple.Services;

namespace SingleResponsibilityPrinciple.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static ServiceProvider ConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<IFileSaverService, FileSaverService>();
            return services.BuildServiceProvider();
        }
    }
}
