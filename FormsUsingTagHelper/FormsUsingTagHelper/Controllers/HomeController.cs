using FormsUsingTagHelper.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FormsUsingTagHelper.Controllers
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
            return View();
        }
        [HttpPost]
        public string Index(Employee e)   // when we click on submit all the data is going to save in Employee object
        {
            return "Name: "+e.Name+"Gender: "+e.Gender+"Designation: "+e.Designation+"Salary: "+e.Salary+"Married:"+e.Married+
                "Description:"+e.Description;
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
