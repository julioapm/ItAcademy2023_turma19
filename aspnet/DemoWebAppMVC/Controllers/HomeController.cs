using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoWebAppMVC.Models;

namespace DemoWebAppMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //GET .../Home/Index
    public IActionResult Index()
    {
        ViewBag.Saudacao = "Alô, Mundo!";
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
}
