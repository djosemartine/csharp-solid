using OpenClosedPrinciple.Models;

namespace OpenClosedPrinciple
{
    public class JuniorSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorSalaryCalculator(DeveloperReport developerReport) : base(developerReport)
        {
            developerReport.Level = DeveloperLevel.Junior;
        }

        public override double CalculateSalary()
        {
            return DeveloperReport.WorkingHours * DeveloperReport.HourlyRate;
        }
    }
}
