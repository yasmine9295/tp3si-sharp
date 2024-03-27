using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion
{
    internal class Categorie
    {
        private string codeCategorie;
        private string libCategorie;

        public string CodeCategorie { get => codeCategorie; set => codeCategorie = value; }
        public string LibCategorie { get => libCategorie; set => libCategorie = value; }

        public Categorie(string codecat, string libcate)
        {
            this.codeCategorie = codecat;
            this.libCategorie = libcate;
        }
        public override string ToString()
        {
            return "\n ---------------------\n code : " + this.codeCategorie + "\n libelle : " + this.libCategorie;
        }
    }
}
