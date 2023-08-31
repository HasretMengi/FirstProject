using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Alchemy.Models;

namespace Alchemy.Controllers;

public class RobotController : Controller
{
    private readonly ILogger<RobotController> _logger;

    // Constructeur 
    public RobotController(ILogger<RobotController> logger)
    {
        _logger = logger;
        // On passe en argument les dependences pour faciliter les text, comme dans le triangle de serpiesnk on passe random en arg pour que les methodes puissent utiliser les dependances utilise en arg

    }

    //Ici on relie la View au Controlleur, il va chercher qqch qui sapelle Index.cshtml
    public IActionResult Bob()
    {

        return View();
    }
    public IActionResult Alice()
    {

        return View();
    }
    public IActionResult Andre()
    {

        return View();
    }

    /*public IActionResult Privacy()
    {
        return View();
    }*/

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
