using System;
using System.Collections.Generic;
using System.Text;

namespace GestionClients
{
    class Categorie
    {
        // attributes
        private string codeCategorie; // code
        private string libCategorie; // libellé

        // accesseurs
        public string CodeCategorie { get => codeCategorie; set => codeCategorie = value; }
        public string LibCategorie { get => libCategorie; set => libCategorie = value; }

        // constructeurs
        public Categorie() { }
        public Categorie(string _code, string _libelle)
        {
            this.CodeCategorie = _code;
            this.LibCategorie = _libelle;
        }

        // methods
        public override string ToString()
        {
            return "Code : " + this.CodeCategorie + "\nLibellé : " + this.LibCategorie;
        }

    }
}
