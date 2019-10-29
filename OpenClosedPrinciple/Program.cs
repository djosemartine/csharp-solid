using OpenClosedPrinciple.Models;
using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Open Closed Principle");
            var devReports = new List<BaseSalaryCalculator>
            {
                new SeniorSalaryCalculator(
                    new DeveloperReport {
                        Id = Guid.NewGuid(), Name = "Dev1", Level = DeveloperLevel.Senior, HourlyRate  = 30.5, WorkingHours = 160
                    }),
                new JuniorSalaryCalculator(
                    new DeveloperReport {
                        Id = Guid.NewGuid(), Name = "Dev2", Level = DeveloperLevel.Junior, HourlyRate  = 20, WorkingHours = 150
                    }),
                new SeniorSalaryCalculator(
                    new DeveloperReport {
                        Id = Guid.NewGuid(), Name = "Dev3", Level = DeveloperLevel.Senior, HourlyRate  = 30.5, WorkingHours = 180
                    })
            };

            var calculator = new SalaryCalculator(devReports);
            Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} dollars");
        }
    }
}
