using Microsoft.AspNetCore.Mvc;

namespace MVCAppDay4Demo.Controllers
{
    public class AnotherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
