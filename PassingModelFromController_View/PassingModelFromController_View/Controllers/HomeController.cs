using Microsoft.AspNetCore.Mvc;
using PassingModelFromController_View.Models;
using System.Diagnostics;

namespace PassingModelFromController_View.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Populating data of Employee
            //var Employees = new List<Employee>()
            //{
            //    new Employee{EmpId= 1, EmpName="Avi",Designation="SDE",Salary=90000000}
            //};


            //Employee emp = new Employee()   // we want to pass this model/object to view
            //{
            //    EmpId=101,
            //    EmpName="Avi",
            //    Designation="SD",
            //    Salary=9000000,
            //};

            // ViewData["myEmp"] = emp;
            //ViewBag.myEmp = emp;
            //TempData["myEmp"] = emp;


            // Creating List of Employee
            var employees = new List<Employee>()    // List collection of Employee Type
            {
                new Employee{EmpId = 1, EmpName="Avinash",Designation="SDE",Salary=1000000},
                new Employee{EmpId= 2, EmpName="Avi",Designation="Manager",Salary=90000000},
                new Employee{EmpId= 2, EmpName="Harsh",Designation="Tester",Salary=20000000}
            };

            // Passing Model of multiple object from controller to view
            ViewData["myemp"] = employees;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
