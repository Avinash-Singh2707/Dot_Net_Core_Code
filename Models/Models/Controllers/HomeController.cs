using Microsoft.AspNetCore.Mvc;
using Models.Models;
using Models.Repository;
using System.Diagnostics;

namespace Models.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        // Declaration of our repository
        private readonly StudentRepository _studentRepository=null;

        public HomeController(ILogger<HomeController> logger)     // Contructor
        {
            _logger = logger;
            _studentRepository = new StudentRepository();   // creating object of StudentRepository
            // Creating the object of StudentRepository to access the method of that Repository....
        }

        // Repository Pattern
        public List<Student> AllStudent()
        {
            // Here we are not returning any view so our data is simply going to represent in a JSON format
            return _studentRepository.getAllStudents();  // try to paas this data into view and rendered it. 
        }
        public Student StudentById(int id)
        {
            return _studentRepository.getStudentById(id);
        }

        public IActionResult Index()
        {
            // Generating Data of Student Model (Manually)
            //var students = new List<Student>
            //{
            //    new Student {rollNo=1,Name="Avi",Gender="Male",Standard=8},
            //    new Student {rollNo=2,Name="Avinash",Gender="Male",Standard=9},
            //    new Student {rollNo=3,Name="Singh",Gender="Male",Standard=1}
            //};

            //ViewData["myStudent"] = students;   

            




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
