namespace Alchemy.Models
{
    public class Robot
    {

        public int Id { get; set; }
        public string UrlImage { get; set; }
        public string Nom { get; set; }
        public string Taille { get; set; }
        public string Poids { get; set; }
        public string Pays { get; set; }

        // Propriété statique pour suivre le prochain ID
        public static int NextId { get; private set; } = 4;

       
    }

    public record Robot2(int Id,string Nom, string UrlImage, string Taille,string Poids,string Pays);
}