using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Gestion
{
    internal class Commerciale
    {
        public string nom;
        public string prenom;
        public int anneeNaissance;
        public Categorie categorie;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int AnneeNaissance { get => anneeNaissance; set => anneeNaissance = value; }
        public Commerciale(string nomC, string prenomC, int anneeNaissanceC, Categorie categorieC)
        {
            this.nom = nomC;
            this.prenom = prenomC;
            this.anneeNaissance = anneeNaissanceC;
            this.categorie = categorieC;
        }

        public double calculAge()
        {
            return DateTime.Now.Year - this.anneeNaissance;

        }
        public override string ToString()
        {
            return "\n ---------------------\n nom : " + this.nom + "\n prenom : " + this.prenom + "\n Année de naissance : " + this.anneeNaissance + "\n Ce commercial a donc " + calculAge();
        }
        public void Compare(Commerciale c)
        {
            if (c.Nom == this.nom)
            {
                Console.WriteLine("\n -----------------------\nLes deux commerciaux ont le même nom de famille.");
            }
            c.Nom = nom;  

        }
    }
}

            
















    





