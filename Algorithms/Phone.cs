namespace Algorithms;

public class Phone {
    //Attribut
    public string Tel;
    //Constructeur
    public Phone (string nom){
        this.Tel = nom;
    }

    public bool IsValid(){
         return Tel.Length >= 10;
    }

}