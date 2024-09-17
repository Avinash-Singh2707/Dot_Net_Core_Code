using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ValidationAttribute.Models;

namespace ValidationAttribute.Controllers
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
        public IActionResult Index(Student st)    // the form is submitting here -> Student st
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();   // we usally write this line when we sent our data to our database.
            }

            return View();
            //// if we want to apply logic after form submission then you use MODELSTATE
            //if (ModelState.IsValid)   // IsValid is true if there is no ERROR (means if user submitted correct data into forms)
            //{
            //    return "Name is:" + st.Name;
            //}
            //else
            //{
            //    return "Validation Failed";
            //}
            
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
