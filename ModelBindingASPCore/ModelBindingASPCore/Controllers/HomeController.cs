using Microsoft.AspNetCore.Mvc;
using ModelBindingASPCore.Models;
using System.Diagnostics;

namespace ModelBindingASPCore.Controllers
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

        // https://localhost:44328/Home/Details/1?Name=Avi   // passing name by "Query String" and id=5 is route data
        // https://localhost:44328/Home/Details?Name=Avi&id=7 // passing id and name by query string. 
        public string Details(int id, string name)   // paasing data through from URL to action method
        {
            return "Id is: " + id + "Name is:" + name;
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
