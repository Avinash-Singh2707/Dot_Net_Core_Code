using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controllers
{
    [Route("Home")]   // To remove duplication of code
    public class HelloController : Controller
    {
        [Route("")]   // Empty Route
        //[Route("Home")]
        //[Route("Home/Index")]    // if we type this URL -> It will execute below actions methods irrespective of name of controller and action methods
        [Route("Index")]
        [Route("~/")]    // it will represent our empty URL when our application will execute first time
        public IActionResult Data()   // if we change our controller and index name then also it will refer Route name
        {
            return View("~/Views/Home/Index.cshtml"); // it will find out data.cshtml but there is no data.cshtml file is present
        }
        //[Route("Home/About")]
        [Route("About")]
        public IActionResult About()
        {
            return View();
        }
        // for Id?
        [Route("Home/Details/{id?}")]   // we can make our id parameter by adding ? just after id  
        public int Details(int? id)
        {
            return id ?? 1;    // if id is null display 1, Right hand side of null coalasing operator
        }

    }
}
