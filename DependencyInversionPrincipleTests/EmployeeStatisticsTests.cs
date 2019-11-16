using DependencyInversionPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DependencyInversionPrincipleTests
{
    public class EmployeeStatisticsTests
    {
        public readonly List<Employee> EmployeesSample = new List<Employee> {
               new Employee { Name = "John Doe", Gender = Gender.Male, Position = Position.Arquitecht },
               new Employee { Name = "Maria Smith", Gender = Gender.Female, Position = Position.Director },
               new Employee { Name = "Will Curtis", Gender = Gender.Other, Position = Position.Developer },
               new Employee { Name = "John Bush", Gender = Gender.Male, Position = Position.Developer },
               new Employee { Name = "Kurt Smith", Gender = Gender.Male, Position = Position.Developer },
               new Employee { Name = "Britney Spears", Gender = Gender.Female, Position = Position.Developer }
            };

        [Fact]
        public void Should_Calculate_Female_Developers_Count()
        {
            var manager = new EmployeeManager(EmployeesSample);
            var statistics = new EmployeeStatistics(manager);
            Assert.Equal(EmployeesSample.Where(e => e.Gender == Gender.Female && e.Position == Position.Developer).Count(), statistics.CountFemaleDevelopers());
        }
    }
}
