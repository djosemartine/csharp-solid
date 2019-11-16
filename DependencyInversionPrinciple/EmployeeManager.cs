using System;
using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    public class EmployeeManager
    {
        public List<Employee> Employees { get; }

        public EmployeeManager()
        {
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            if (employee == null) throw new ArgumentNullException(nameof(employee));
            Employees.Add(employee);
        }
    }
}
