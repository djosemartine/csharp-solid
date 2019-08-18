using Microsoft.Extensions.DependencyInjection;
using SingleResponsibilityPrinciple.Models;
using SingleResponsibilityPrinciple.Services;
using System;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Responsibilty Principle");
            // Register services
            var services = new ServiceCollection();
            var serviceProvider = ConfigureServices(services);
            // Get Services
            var fileSaverService = serviceProvider.GetService<IFileSaverService>();

            var report = new WorkReport();
            report.AddEntry(new WorkReportEntry { Name = "Entry 1", ProjectCode = "CO-100", SpentHours = 10 });
            report.AddEntry(new WorkReportEntry { Name = "Entry 2", ProjectCode = "CO-101", SpentHours = 20 });
            fileSaverService.SaveToFile("Reports", "SRP-Report.txt", report);
            Console.WriteLine(report.ToString());
        }

        private static ServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IFileSaverService, FileSaverService>();
            return services.BuildServiceProvider();
        }
    }
}
