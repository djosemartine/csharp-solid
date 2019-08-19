using OpenClosedPrinciple.Models;

namespace OpenClosedPrinciple
{
    public class SeniorSalaryCalculator : BaseSalaryCalculator
    {
        public SeniorSalaryCalculator(DeveloperReport developerReport) : base(developerReport)
        {
            developerReport.Level = DeveloperLevel.Senior;
        }

        public override double CalculateSalary()
        {
            return DeveloperReport.HourlyRate * DeveloperReport.WorkingHours * 1.2;
        }
    }
}
