using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion
{
    internal class Service
    {
        private string nom;
        private Commerciale[] tableauCom;
        private int effectif;

        public string Nom { get => nom; set => nom = value; }
        public int Effectif { get => effectif; set => effectif = value; }
        internal Commerciale[] TableauCom { get => tableauCom; set => tableauCom = value; }
        public Service(string nomS)
        {
            this.Nom = nomS;
            this.tableauCom = new Commerciale[10];
            this.effectif = 0;

        }

        public void ajouterCom(Commerciale c)
        {
            tableauCom[Effectif] = c;
            Effectif ++;
        }
        public void afficherCommerciaux()
        {
           Console.WriteLine("liste des commerciaux du service " + this.nom+"--------\n");
           foreach (Commerciale c in tableauCom)
            {
                if (c != null) { 
                Console.WriteLine(c);
                }
            }
            Console.WriteLine("----------------------------------\n");
        }


    } 
}

