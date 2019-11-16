using DependencyInversionPrinciple;
using DependencyInversionPrinciple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DependencyInversionPrincipleTests
{
    public class EmployeeManagerTests
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
        public void Should_initialize_employees()
        {
            var employeeManager = new EmployeeManager();
            Assert.Empty(employeeManager.GetAll);
        }

        [Fact]
        public void Should_create_employees()
        {
            var employeeManager = new EmployeeManager(EmployeesSample);
            Assert.NotEmpty(employeeManager.GetAll);
            Assert.Equal(EmployeesSample.Count, employeeManager.GetAll.ToList().Count);
        }

        [Fact]
        public void Should_Add()
        {
            var employeeManager = new EmployeeManager();
            employeeManager.AddEmployee(EmployeesSample.First());
            Assert.Single(employeeManager.GetAll.ToList());
            Assert.Equal(EmployeesSample.First(), employeeManager.GetAll.First());
        }

        [Fact]
        public void Should_Search()
        {
            var employeeManager = new EmployeeManager();
            var employees = employeeManager.Search(new SearchEmployee
            {
                Gender = Gender.Female
            });
            Assert.Empty(employees);
        }

        [Fact]
        public void Should_Search_Default()
        {
            var employeeManager = new EmployeeManager(EmployeesSample);
            var employees = employeeManager.Search(default);
            Assert.Equal(EmployeesSample, employees);
        }

        [Theory]
        [InlineData("Maria Smith")]
        [InlineData("John Doe")]
        public void Should_Search_By_Name(string name)
        {
            var employeeManager = new EmployeeManager(EmployeesSample);
            var employees = employeeManager.Search(new SearchEmployee
            {
                Name = name
            });
            Assert.Single(employees);
            Assert.Equal(EmployeesSample.Where(e => e.Name == name), employees);
        }

        [Theory]
        [InlineData(Gender.Male)]
        [InlineData(Gender.Female)]
        [InlineData(Gender.Other)]
        public void Should_Search_By_Gender(Gender gender)
        {
            var employeeManager = new EmployeeManager(EmployeesSample);
            var employees = employeeManager.Search(new SearchEmployee
            {
                Gender = gender
            });
            Assert.Equal(EmployeesSample.Where(e => e.Gender == gender), employees);
        }
    }
}
