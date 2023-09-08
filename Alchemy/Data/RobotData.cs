using System.Collections.Generic;

namespace Alchemy.Models
{
    public static class RobotData
    {
        public static List<Robot> Robots { get; } = new List<Robot>
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

        public static void AddRobot(Robot newRobot)
        {
            Robots.Add(newRobot);
        }

        public static Robot GetRobotById(int idRobot)
        {
            // Recherchez le robot par son nom dans la liste
            var robot = Robots.FirstOrDefault(r => r.Id == idRobot);
            return robot;
        }

        public static void UpdateRobotPays(int idRobot, string nouveauPays)
        {
            // Recherchez le robot par son ID dans la liste
            var robot = Robots.FirstOrDefault(r => r.Id == idRobot);
            if (robot != null)
            {
                robot.Pays = nouveauPays;
            }
        }

        public static void DeleteRobot(int idRobot)
        {
            // Recherchez le robot par son ID dans la liste
            var robot = Robots.FirstOrDefault(r => r.Id == idRobot);

            if (robot != null)
            {
                // Supprimez le robot de la liste
                Robots.Remove(robot);

                // Triez la liste des robots par ID
                Robots.Sort((r1, r2) => r1.Id.CompareTo(r2.Id));

                // Mettez à jour les ID de chaque robot en fonction de leur position
                for (int i = 0; i < Robots.Count; i++)
                {
                    Robots[i].Id = i + 1;
                }
            }
        }


    }
}