using System;
using System.Collections.Generic;
using System.Linq;
using DependencyInversionPrinciple.Models;

namespace DependencyInversionPrinciple
{
    public class EmployeeManager : IEmployeeSearcher
    {
        private readonly List<Employee> _employees;

        public EmployeeManager()
        {
            _employees = new List<Employee>();
        }

        public EmployeeManager(IEnumerable<Employee> employees)
        {
            _employees = employees?.ToList() ?? throw new ArgumentNullException(nameof(employees));
        }

        public void AddEmployee(Employee employee)
        {
            if (employee == null) throw new ArgumentNullException(nameof(employee));
            _employees.Add(employee);
        }

        public IEnumerable<Employee> GetAll => _employees;

        public IEnumerable<Employee> Search(SearchEmployee employee)
        {
            if (!_employees.Any() || employee == null) return _employees;
            var search = _employees;
            if (!string.IsNullOrWhiteSpace(employee.Name)) search.AddRange(search.Where(e => e.Name.Contains(employee.Name)));
            if (employee.Gender.HasValue) search = search.Where(e => e.Gender == employee.Gender).ToList();
            if (employee.Position.HasValue) search = search.Where(e => e.Position == employee.Position).ToList();
            return search;
        }
    }
}
