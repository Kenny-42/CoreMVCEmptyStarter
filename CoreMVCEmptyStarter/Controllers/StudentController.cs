using Microsoft.AspNetCore.Mvc;

namespace CoreMVCEmptyStarter.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
