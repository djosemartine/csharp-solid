using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<BaseSalaryCalculator> _developerReports;

        public SalaryCalculator(IEnumerable<BaseSalaryCalculator> developerReports)
        {
            _developerReports = developerReports ?? throw new ArgumentNullException(nameof(developerReports));
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0;
            foreach (var report in _developerReports)
            {
                totalSalaries += report.CalculateSalary();

            }
            return totalSalaries;
        }
    }
}
