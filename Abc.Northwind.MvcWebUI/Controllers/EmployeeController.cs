using Abc.Northwind.Business.Abstract;
using Abc.Northwind.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Abc.Northwind.MvcWebUI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            var model = new EmployeeListViewModel();
            model.EmployeeList = _employeeService.GetAll();
            return View(model);
        }
    }
}
