using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Alchemy.Models;

namespace Alchemy.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    
    // Constructeur 
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        // On passe en argument les dependences pour faciliter les text, comme dans le triangle de serpiesnk on passe random en arg pour que les methodes puissent utiliser les dependances utilise en arg
        
    }

    public IActionResult Index()
    {
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
