using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Alchemy.Models;

namespace Alchemy.Controllers;

public class AboutController : Controller
{
    private readonly ILogger<AboutController> _logger;

    // Constructeur 
    public AboutController(ILogger<AboutController> logger)
    {
        _logger = logger;

    }

    // Il faut creer une action pour afficher quelquechose sinon ca donne 404 
    public string Index()
    {
        return "Page about";
    }
    //Si je veux marquer /about/me, il y aura rien donc je doit creer une methode public me aka une autre action Me()
   public string Me(string name = "no name")
    {
        name = "Rabia";
        return "this is /about/me & this is my name: " + name;
    }

  
     public IActionResult ShowNameView(string nom = "no name")
    {
        ViewData["nom"] = "Rabia";
        return View();
    }


}
