namespace Algorithms;

public class PostalCode {
    //Attribut
    public string Postal;
    //Constructeur
    public PostalCode (string nom){
        this.Postal = nom;
    }

    public bool IsValid(){
         return Postal.Length > 5;
    }

}