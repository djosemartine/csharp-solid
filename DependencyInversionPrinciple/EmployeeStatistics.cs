using System;
using System.Linq;

namespace DependencyInversionPrinciple
{
    public class EmployeeStatistics
    {
        private readonly EmployeeManager _employeeManager;

        public EmployeeStatistics(EmployeeManager employeeManager)
        {
            _employeeManager = employeeManager ?? throw new ArgumentNullException(nameof(employeeManager));
        }

        public int CountFemaleDevelopers()
        {
            return _employeeManager.Employees.Count(e => e.Gender == Gender.Female && e.Position == Position.Developer);
        }
    }
}
