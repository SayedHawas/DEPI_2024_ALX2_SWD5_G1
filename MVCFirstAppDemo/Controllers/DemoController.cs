using Microsoft.AspNetCore.Mvc;

namespace MVCFirstAppDemo.Controllers
{
    public class DemoController : Controller
    {
        // Method  Run HTTP Request
        // 1- Public 
        // 2- Return 
        // 3- Not OverLoad (In Case )

        //http://localhost:5219/demo/showhello
        public string ShowHello()
        {
            return "Welcome in MVC Core ";
        }

        //public ContentResult SayContent()
        public IActionResult SayContent()
        {
            ContentResult result = new ContentResult();
            result.Content = "Welcome in MVC Content Result";
            return result;
        }

        //public FileResult ShowFile()
        public IActionResult ShowFile()
        {
            return File("~/Welcome.txt", "text/plain");
        }

        //public JsonResult ShowJson()
        public IActionResult ShowJson()
        {
            return Json(new { Id = 1, Name = "Osama" });
        }

    }
}
