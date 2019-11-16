using DependencyInversionPrinciple.Models;
using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    public interface IEmployeeSearcher
    {
        IEnumerable<Employee> Search(SearchEmployee employee);
    }
}
