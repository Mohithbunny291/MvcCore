using Microsoft.AspNetCore.Mvc;
using MvcCore.Models;

namespace MvcCore.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee{Id = 1, Name = "Sam", Designation = "HR", Salary = 120000, Doj = new DateTime(day:10, month:1, year:2021)}

        };

        public IActionResult Index()
        {
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Employee());
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if(employee != null)
            {
                if(ModelState.IsValid)
                {
                    employees.Add(employee);
                    return RedirectToAction("Index");
                }
            }
            return View(employee);
        }

        public IActionResult Delete(Employee employee)
        {
            if(employee.Id != 0)
            {
                employee.remove();
            }
        }
    }
}
