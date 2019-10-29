using System;
using System.Collections.Generic;
using System.Linq;

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
            return _developerReports.Sum(report => report.CalculateSalary());
        }
    }
}
