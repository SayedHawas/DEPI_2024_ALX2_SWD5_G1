using Microsoft.AspNetCore.Mvc;

namespace Day2MVC_Demo.Controllers
{
    public class DemoController : Controller
    {
        //Routing 
        // demo/Index
        public IActionResult Index()
        {

            //return new EmptyResult();
            //return Content("Welcome in MVC ");
            //return Json(new {id=10, Name = "Magdy" });
            return View();
        }

        //demo/Sayhello/5
        //ID Routing value 
        public IActionResult SayHello(int id)
        {
            return Content($"Welcome in MVC {id} ");
        }
        //http://localhost:5274/demo/saywelcome?name=ahmed
        public IActionResult SayWelcome(string name)
        {
            return Content($"Welcome : {name} ");
        }
        //Query String 
        //http://localhost:5274/demo/sayNumber?number=10
        public string SayNumber(int number)
        {
            return $"Welcome in MVC {number} ";
        }


        public IActionResult ShowAction()
        {
            //Do some things 
            return RedirectToAction("JsonFile");
        }

        public IActionResult JsonFile()
        {
            return Json(new { ID = 5, Name = "Osama", Salary = 15000 });
        }

        public IActionResult ShowHomeIndex()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ShowHotmail()
        {
            return Redirect("http://www.hotmail.com");
        }

        public IActionResult Showyahoo()
        {
            return RedirectPermanent("http://www.yahoo.com");
        }

    }
}
