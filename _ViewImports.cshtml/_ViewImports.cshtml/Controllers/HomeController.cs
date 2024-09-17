using AspViewImports.Models;
using Microsoft.AspNetCore.Mvc;


namespace _ViewImports.cshtml.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id=1,Name="Avi",Gender="Male"},
                new Student { Id = 2, Name = "Avinash", Gender = "Male" },
                new Student { Id = 3, Name = "Singh", Gender = "Male" }
            };

            return View(students);
        }
        public IActionResult About()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id=1,Name="Avi",Gender="Male"},
                new Student { Id = 2, Name = "Avinash", Gender = "Male" },
                new Student { Id = 3, Name = "Singh", Gender = "Male" }
            };
            return View(students);
        }
        public IActionResult Contact()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id=1,Name="Avi",Gender="Male"},
                new Student { Id = 2, Name = "Avinash", Gender = "Male" },
                new Student { Id = 3, Name = "Singh", Gender = "Male" }
            };
            return View(students);
        }
    }
}
