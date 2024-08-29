using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StudentDetails()
        {
            return View("studentView");
        } 
        public IActionResult AddStudent()
        {
            return View();
        }
    }

}
