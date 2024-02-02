using Microsoft.AspNetCore.Mvc;

namespace prjPractise.Controllers
{
    public class HomeWorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult travel()
        {
            return View();
        }
    }
}
