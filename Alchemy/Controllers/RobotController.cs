using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Alchemy.Models;
namespace Alchemy.Controllers
{
    public class AddRobotRequest
    {
        public string Nom { get; set; }
        public string Taille { get; set; }
        public string Poids { get; set; }
        public string Pays { get; set; }
    }


    public class RobotController : Controller
    {
        private readonly ILogger<RobotController> _logger;

        public RobotController(ILogger<RobotController> logger)
        {
            _logger = logger;
        }


        public IActionResult WantedRobotList()
        {
            var robots = RobotData.Robots;
            return View(robots);
        }

        public ActionResult RobotDetails(int id)
        {
            // Recherchez le robot par son nom dans la liste
            var robot = RobotData.GetRobotById(id);
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
            int maxId = RobotData.Robots.Max(r => r.Id);

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
            RobotData.AddRobot(newRobot);

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
            RobotData.UpdateRobotPays(idRobot, nouveauPays);

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
            RobotData.DeleteRobot(idRobot);

            // Redirigez l'utilisateur vers la page de détails du robot mis à jour
            return RedirectToAction("WantedRobotList");
        }



    }

}