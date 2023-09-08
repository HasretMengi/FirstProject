namespace Alchemy.Models
{
    public class Robot
    {
        private static int _currentId = 1;
        public int Id { get; set; }
        public string UrlImage { get; set; }
        public string Nom { get; set; }
        public string Taille { get; set; }
        public string Poids { get; set; }
        public string Pays { get; set; }

        // Propriété statique pour suivre le prochain ID
        public static int NextId { get; private set; } = 4;

       // Constructeur qui incrémente automatiquement l'ID
        public Robot()
        {
            Id = _currentId++;
        }

    }
}