using Microsoft.AspNetCore.Mvc;
using StronglyTypedViews.Models;
using System.Diagnostics;

namespace StronglyTypedViews.Controllers
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
            //Employee emp = new Employee()
            //{
            //    EmpId = 1,
            //    EmpName = "Avi",
            //    Designation = "SDE",
            //    Salary = 90000000
            //};

            // Passing a List Of OBJECT
            var emp = new List<Employee>()
            {
                new Employee {EmpId=101,EmpName="Avi",Designation="SDE",Salary=9000000},
                new Employee {EmpId=102,EmpName="Avi",Designation="SDE",Salary=9000000},
                new Employee {EmpId=103,EmpName="Avi",Designation="SDE",Salary=9000000}
            };

            return View(emp);     // Strongly typed views  // Go to index.cshtml to bind this model to a index view
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
