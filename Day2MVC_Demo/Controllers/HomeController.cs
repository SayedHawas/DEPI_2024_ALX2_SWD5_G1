using Day2MVC_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Day2MVC_Demo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //return View("");
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

    public IActionResult MyAction()
    {
        // HomeController
        // Look for  Views --> Folder With Name {Home}
        //Search Into About --> File With Action Name {MyAction.cshtml}
        //return View();
        return View("MyView");
    }



}
