using OpenClosedPrinciple.Models;
using System;

namespace OpenClosedPrinciple
{
    public abstract class BaseSalaryCalculator
    {
        protected DeveloperReport DeveloperReport { get; private set; }

        public BaseSalaryCalculator(DeveloperReport developerReport)
        {
            DeveloperReport = developerReport ?? throw new ArgumentNullException(nameof(developerReport));
        }

        public abstract double CalculateSalary();
    }
}
