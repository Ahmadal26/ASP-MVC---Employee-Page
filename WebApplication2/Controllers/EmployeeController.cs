using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller

    {
        static List<Employee> employees = new List<Employee>
{

    new Employee {EmployeeId = "833217",FirstName= "Ahmad",LastName = "Musallam",Email = "833217@kfh.com",Department  = "IT"},
    new Employee {EmployeeId = "833216",FirstName= "Mubark",LastName = "Oraifan",Email = "833216@kfh.com",Department  = "HR"},
    new Employee {EmployeeId = "831315",FirstName= "Abdullah",LastName = "Binessa",Email = "831315@kfh.com",Department  = "IT"},
};

        public IActionResult Index()
        {
            return View(employees);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Submit(IFormCollection from)
        {
            var firstName = from["FirstName"];
            var lastName = from["LastName"];
            var email = from["Email"];
            var department = from["Department"];
            var employeeId = from["EmployeeId"];

            employees.Add(new Employee()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Department = department,
                EmployeeId = employeeId,

            });
            return RedirectToAction("Index");
        }

        public IActionResult Details(string employeeId)
        {
            var employee = employees.Find(c => c.EmployeeId == employeeId);
            if (employee == null)
            {
                return RedirectToAction("Index");
            }
            else
                return View(employee);
        }

    }
}
