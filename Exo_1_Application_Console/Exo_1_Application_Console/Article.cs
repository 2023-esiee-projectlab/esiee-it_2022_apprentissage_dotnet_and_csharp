//-Importation des classes système
using System;

/**
 * Classe article
 */
public class Article
{

    //-Attribut de nom de l'article.
    public string nom;
    //-Attribut de prix de l'article.
    public double prix;
    //-Attribut de quantite de l'article.
    public int quantite;

    //Getter et Setter de l'attribut de nom de l'article.
    public string Nom{ get { return nom; } set { nom = value;} }
    //Getter et Setter de l'attribut de prix de l'article
    public double Prix { get => prix; set => prix = value; }
    //Getter et Setter de l'attribut de quantite de l'article
    public int Quantite { get; set;  }

    /**
     * Constructeur complet de la classe article.
     */
    public Article(string nom, double prix, int quantite){
        this.nom = nom;
        this.prix = prix;
        this.quantite = quantite;
    }

    /**
     * Acheter un article.
     */
    public void acheter(){}

    /**
    * Afficher dans la console les champs d'un article.
    */
    public void afficher(){
        Console.WriteLine(
            "[Article]"
            +"\n-nom:"+nom
            +"\n-prix:"+prix
            +"\n-quantite:"+quantite
            );
    }

    /**
    * Ajouter un nombre entier positif à la quantité disponible.
    */
    public void ajouter(int quantite){
        this.quantite += quantite;
    }

    /**
    * Retirer un nombre entier positif à la quantité disponible.
    */
    public void retirer(int quantite){
        this.quantite -= quantite;
    }

}