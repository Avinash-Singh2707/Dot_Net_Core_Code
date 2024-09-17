using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ControllerAndActions.Controllers
{
    public class HomeController : Controller
    {
        //IActionResult is an Interface which is implemented by many class -> ViewResult,
        //PartialViewResult , Json Result etc.
        public ViewResult Index()     // IActionResult is an Interface
        {
            // VIEW DATA:

            //ViewData["Data1"] = "Avinash";
            //ViewData["Data2"] = 25;
            //ViewData["Data3"] = DateTime.Now.ToLongDateString();

            //string[] s = { "Avi", "Singh", "Kumar" };
            //ViewData["Data4"] = s;

            ////GENERIC LIST
            //ViewData["Data5"] = new List<string>()
            //{
            //    "Cricket","Football","Hockey"
            //};

            // VIEW BAG
            //ViewBag.data1 = "Avi"; // .data1 -> dynamic property whose data type check at run time So TypeCasting do not require
            //ViewData["data2"] = "Singh";


            // TempData
            ViewData["data1"] = "View Data";
            ViewBag.data2 = "ViewBag";
            TempData["data3"] = "TempData";
            TempData.Keep();   // To keep value of TempData in a third request

            //TempData.Keep("data3");   // if you want to keep any specific data so you can this way
            return View();  //it will return only view
        }
        public IActionResult About()
        {
            TempData.Keep();
            return View();
        }
        public IActionResult Contact()
        {
            TempData.Keep();
            return View();
        }
    }
}
