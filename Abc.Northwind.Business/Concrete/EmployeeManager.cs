using Abc.Northwind.Business.Abstract;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace Abc.Northwind.Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeDal.Get(p=> p.EmployeeID==id);
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetList();
        }

        public List<Employee> GetEmployeesByFirstName(string firstName)
        {
            return _employeeDal.GetList(p=> p.FirstName==firstName);
        }

        public List<Employee> GetEmployeesByLastName(string lastName)
        {
            return _employeeDal.GetList(p => p.LastName == lastName);
        }
    }
}
