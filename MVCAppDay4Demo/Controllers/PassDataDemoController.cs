using Microsoft.AspNetCore.Mvc;

namespace MVCAppDay4Demo.Controllers
{
    public class PassDataDemoController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("session1", "welcome in My site Until Brower Closes");
            //Pass Data Between Action To view 
            TempData["FullRequest"] = " Pass Data From Temp Data";
            ViewData["ViewDataVal"] = "Pass Data From View Data ";
            ViewBag.viewbagval = "Pass Data From View bag ";
            //return View();
            return RedirectToAction("Show");
            //return RedirectToAction("Index", controllerName: "Another");
        }

        public IActionResult Show()
        {

            return View();
        }


        public IActionResult SetTempData()
        {
            TempData["AppName"] = "Smart software";
            return Content("Save Data into Temp Data ");
        }

        //public IActionResult GetFirst()
        //{
        //    string name = "Empty Name ";
        //    if (TempData.ContainsKey("AppName"))
        //    {
        //        //normal read
        //        name = TempData["AppName"].ToString();
        //    }

        //    return Content(" get Data " + name + " Please check cookies ...");
        //}
        public IActionResult GetSecond()
        {
            //Normal Read
            string name = TempData["AppName"].ToString();
            return Content(" get Data " + name + " Please check cookies ...");
        }

        public IActionResult GetFirst()
        {
            string name = "Empty Name ";
            if (TempData.ContainsKey("AppName"))
            {
                name = TempData.Peek("AppName").ToString();
                //name = TempData["AppName"].ToString();
            }

            return Content(" get Data " + name + " Please check cookies ...");
        }


        public IActionResult SetCookies()
        {
            Response.Cookies.Append("AppName", "Smart software");  //Session Cookies 20 Min
            Response.Cookies.Append("Number", "120");

            return Content("Cookies Saving ....");
        }

        public IActionResult GetCookies()
        {
            string appName = Request.Cookies["AppName"];
            int Number = int.Parse(Request.Cookies["Number"]);

            return Content($"Cookies:{appName} & {Number}");
        }

        public IActionResult SetCookiesPersistent()
        {
            CookieOptions cookieOptions = new CookieOptions();
            //cookieOptions.Expires = DateTimeOffset.Now.AddHours(3);
            cookieOptions.Expires = DateTimeOffset.Now.AddDays(15);
            Response.Cookies.Append("CompanyName", "Smart software", cookieOptions);

            return Content("Cookies Persistent Saving ....");
        }
        public IActionResult GetCookiesPersistent()
        {
            string companyName = Request.Cookies["CompanyName"];

            return Content($"Cookies:{companyName}");
        }
        public IActionResult RemoveCookies()
        {
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTimeOffset.Now.AddDays(-1);
            Response.Cookies.Append("CompanyName", "Smart software", cookieOptions);

            return Content($"Check Cookies .... !");
        }



        public IActionResult SetSession()
        {
            HttpContext.Session.SetString("name", "Sayed");//(Key , Value String)
            HttpContext.Session.SetInt32("Counter", 100);//(Key , Value Int)
            return Content("Save Session ");
        }
        public IActionResult GetSession()
        {
            string name = HttpContext.Session.GetString("name");
            int? counter = HttpContext.Session.GetInt32("Counter");
            return Content($"Name {name} & Counter {counter}  ");
        }

        public IActionResult ShowQueryString()
        {
            var name = HttpContext.Request.Query["name"];
            var age = HttpContext.Request.Query["age"];
            ViewBag.Name = name;
            ViewBag.Age = age;
            return View();
        }
    }
}
