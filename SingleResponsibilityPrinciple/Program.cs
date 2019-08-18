using SingleResponsibilityPrinciple.Models;
using System;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Responsibilty Principle");
            var report = new WorkReport();
            report.AddEntry(new WorkReportEntry { Name = "Entry 1", ProjectCode = "CO-100", SpentHours = 10 });
            report.AddEntry(new WorkReportEntry { Name = "Entry 2", ProjectCode = "CO-101", SpentHours = 20 });

            Console.WriteLine(report.ToString());
            report.SaveToFile("Reports", "reports.txt");
        }
    }
}
