using Abc.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace Abc.Northwind.Business.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        List<Employee> GetEmployeesByFirstName(string firstName);
        List<Employee> GetEmployeesByLastName(string lastName);
        Employee GetEmployeeById(int id);


    }
}
