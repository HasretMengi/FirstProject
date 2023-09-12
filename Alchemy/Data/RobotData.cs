using System.Collections.Generic;

namespace Alchemy.Models
{
    public class RobotData : IRobotData
    {
        private int _nextId = 4;
        public List<Robot> Robots { get; } = new List<Robot>
        {
            new Robot
                {
                    Id = 1,
                    UrlImage = "https://robohash.org/Alice",
                    Nom = "Alice",
                    Taille = "7.90 m",
                    Poids = "5000 kg",
                    Pays = "Palestine"
                },
                new Robot
                {
                    Id = 2,
                    UrlImage = "https://robohash.org/Andre",
                    Nom = "Andre",
                    Taille = "10.90 m",
                    Poids = "9000 kg",
                    Pays = "Turquie"
                },
                new Robot
                {
                    Id = 3,
                    UrlImage = "https://robohash.org/Bob",
                    Nom = "Bob",
                    Taille = "5.90 m",
                    Poids = "4000 kg",
                    Pays = "Brésil"
                }
        };

        public void AddRobot(Robot newRobot)
        {
            newRobot.Id = _nextId;
            Robots.Add(newRobot);
            _nextId++;
        }

        public Robot GetRobotById(int idRobot)
        {
            // Recherchez le robot par son ID dans la liste
            var robot = Robots.FirstOrDefault(r => r.Id == idRobot);
            return robot;
        }
        public Robot GetRobotByName(string nomRobot)
        {
             var robot = Robots.FirstOrDefault(r => r.Nom == nomRobot);
            return robot;
        }

        public void UpdateRobotPays(int idRobot, string nouveauPays)
        {
            // Recherchez le robot par son ID dans la liste
            var robot = Robots.FirstOrDefault(r => r.Id == idRobot);
            if (robot != null)
            {
                robot.Pays = nouveauPays;
            }
        }

        public void DeleteRobot(int idRobot)
        {
            // Recherchez le robot par son ID dans la liste
            var robot = Robots.FirstOrDefault(r => r.Id == idRobot);

            if (robot != null)
            {
                // Supprimez le robot de la liste
                Robots.Remove(robot);

            }
        }


    }
}