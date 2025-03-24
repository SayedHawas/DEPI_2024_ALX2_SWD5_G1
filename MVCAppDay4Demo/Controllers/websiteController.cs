using Microsoft.AspNetCore.Mvc;

namespace MVCAppDay4Demo.Controllers
{
    public class websiteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
