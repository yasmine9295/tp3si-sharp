using Gestion;
internal class Program
{
    static void Main(string[] args)
    {
        
        Categorie categorie1 = new Categorie("if", "jl");
        Categorie categorie2 = new Categorie("er", "ff");
        Commerciale commerciale1 = new Commerciale("El Harim", "Yasmine", 2005, categorie1);
        Commerciale commerciale2 = new Commerciale("Razengan", "Akira", 2006, categorie2);
        Commerciale commerciale3 = new Commerciale("li", "dz", 2000, categorie1);

        commerciale1.Compare(commerciale2);
        Service s1 = new Service("National");
        Service s2 = new Service("International");
        Console.WriteLine("liste des commerciaux :");
        Console.WriteLine(commerciale1);
        Console.WriteLine(commerciale2);
        Console.WriteLine(categorie1);
        Console.WriteLine(commerciale3);
        Console.WriteLine(categorie2);


        s1.ajouterCom(commerciale1);
        s1.ajouterCom(commerciale2);
        s1.ajouterCom(commerciale3);
        s2.ajouterCom(commerciale1);
        s2.ajouterCom(commerciale2);
        s2.ajouterCom(commerciale3);
        s1.afficherCommerciaux();
        s2.afficherCommerciaux();

    }
}