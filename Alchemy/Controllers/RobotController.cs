using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Alchemy.Models;
namespace Alchemy.Controllers
{
    public class AddRobotRequest
    {
        public string? Nom { get; set; }
        public int Taille { get; set; }
        public int Poids { get; set; }
        public string? Pays { get; set; }
    }


    public class RobotController : Controller
    {
        private readonly ILogger<RobotController> _logger; 
         private readonly IRobotData robotData;//

        public RobotController(ILogger<RobotController> logger, IRobotData robotData)
        {
            _logger = logger;
             this.robotData = robotData; //
        }


        public IActionResult WantedRobotList()
        {
            var robots = robotData.Robots;
            return View(robots);
        }

        public ActionResult RobotDetails(int id)
        {
            // Recherchez le robot par son nom dans la liste
            var robot = robotData.GetRobotById(id);
            if (robot == null)
            {
                return NotFound();
            }
            return View(robot);
        }

        public IActionResult AddRobot()
        {
            return View();
        }



        [HttpPost]
        [ActionName("ajout-robot")]
        public IActionResult AjoutRobot(AddRobotRequest req)
        {
            // Trouvez la valeur de l'ID la plus élevée actuellement utilisée
            int maxId = robotData.Robots.Max(r => r.Id);

            // Incrémentez l'ID pour le nouveau robot
            int newId = maxId + 1;

            // Créez un nouveau robot avec le nouvel ID
            var newRobot = new Robot
            {
                Id = newId,
                Nom = req.Nom,
                Taille = req.Taille,
                Poids = req.Poids,
                Pays = req.Pays
            };

            // Ajoutez le nouveau robot à la liste existante
            robotData.AddRobot(newRobot);

            // Redirigez directement vers la page "WantedRobotList"
            return RedirectToAction("WantedRobotList");
        }

        public IActionResult UpdateRobotPays()
        {

            return View();
        }

        [HttpPost]
        public IActionResult UpdateRobotPays(int idRobot, string nouveauPays)
        {
            // Appelez la méthode de mise à jour dans RobotData avec l'ID
            robotData.UpdateRobotPays(idRobot, nouveauPays);

            // Redirigez l'utilisateur vers la page de détails du robot mis à jour
            return RedirectToAction("RobotDetails", new { id = idRobot });
        }

        public IActionResult DeleteRobot()
        {

            return View();
        }

        [HttpPost]
        public IActionResult DeleteRobot(int idRobot)
        {
            // Appelez la méthode de mise à jour dans RobotData avec l'ID
            robotData.DeleteRobot(idRobot);

            // Redirigez l'utilisateur vers la page de détails du robot mis à jour
            return RedirectToAction("WantedRobotList");
        }

    

    }

}