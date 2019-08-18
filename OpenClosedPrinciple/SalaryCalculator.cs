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
                totalSalaries += report.WorkingHours * report.HourlyRate;
            }
            return totalSalaries;
        }
    }
}
