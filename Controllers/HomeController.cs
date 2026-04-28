using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP1bis_Martinez_Waserman.Models;

namespace TP1bis_Martinez_Waserman.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        Complejo complejo = new Complejo();
        ViewBag.complejo = complejo;
        return View();
    }
    public IActionResult selectCabana(int ID){
        Complejo complejo = new Complejo();
        ViewBag.cabana = complejo.getCabana(ID);
        return View("infoCabana");
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
