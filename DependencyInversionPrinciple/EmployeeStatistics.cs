using DependencyInversionPrinciple.Models;
using System;
using System.Linq;

namespace DependencyInversionPrinciple
{
    public class EmployeeStatistics
    {
        private readonly IEmployeeSearcher _employeeSearcher;

        public EmployeeStatistics(IEmployeeSearcher employeeSearcher)
        {
            _employeeSearcher = employeeSearcher ?? throw new ArgumentNullException(nameof(employeeSearcher));
        }

        public int CountFemaleDevelopers()
        {
            return _employeeSearcher.Search(new SearchEmployee
            {
                Position = Position.Developer,
                Gender = Gender.Female
            }).Count();
        }
    }
}
