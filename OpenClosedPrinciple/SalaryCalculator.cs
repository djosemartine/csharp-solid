using OpenClosedPrinciple.Models;
using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<DeveloperReport> _developerReports;

        public SalaryCalculator(IEnumerable<DeveloperReport> developerReports)
        {
            _developerReports = developerReports ?? throw new ArgumentNullException(nameof(developerReports));
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0;
            foreach (var report in _developerReports)
            {
                if (report.Level == DeveloperLevel.Senior)
                {
                    totalSalaries += report.WorkingHours * report.HourlyRate * 1.2;
                }
                else if (report.Level == DeveloperLevel.Junior)
                {
                    totalSalaries += report.WorkingHours * report.HourlyRate;
                }
                else
                {
                    throw new NotImplementedException($"Developer Type {report.Level.ToString()} Not Found");
                }

            }
            return totalSalaries;
        }
    }
}
