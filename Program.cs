using Gestion;
internal class Program
{
    static void Main(string[] args)
    {
        Commerciale commerciale1 = new Commerciale("El Harim","Yasmine",2005);
        Commerciale commerciale2 = new Commerciale("Razengan", "Akira", 2006);
        Commerciale commerciale3 = new Commerciale("li", "dz", 2000);
        Categorie categorie1 = new Categorie("if", "jl");
        Categorie categorie2 = new Categorie("er", "ff");
        Console.WriteLine(commerciale1);
        Console.WriteLine(commerciale2);
        Console.WriteLine(categorie1);
        Console.WriteLine(commerciale3);
        Console.WriteLine(categorie2);

        commerciale1.Compare(commerciale2);
    }
}