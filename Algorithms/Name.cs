namespace Algorithms;

public class Name
{
    //Attribut
    public string Nom;
    //Constructeur
    public Name(string nom)
    {
        this.Nom = nom;
    }

    public bool IsValid()
    {
        return Nom.Length > 2;
    }

}