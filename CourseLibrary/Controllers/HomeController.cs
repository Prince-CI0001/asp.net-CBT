using Microsoft.AspNetCore.Mvc;

namespace CourseLibrary.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
