using System;
using System.Collections.Generic;
using System.Text;

namespace GestionClients
{
    class Commercial
    {
        // attributes
        private string nom;
        private string prenom;
        private int anneeNaiss;
        private Categorie catCommercial;
        private Service serCom;

        // accesseurs
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int AnneeNaiss { get => anneeNaiss; set => anneeNaiss = value; }
        internal Categorie CatCommercial { get => catCommercial; set => catCommercial = value; }
        internal Service SerCom { get => serCom; set => serCom = value; }

        // constructors
        public Commercial() { }
        public Commercial(string _nom, string _prenom, int _annee, Categorie _catComm, Service _serComm)
        {
            this.Nom = _nom;
            this.Prenom = _prenom;
            this.AnneeNaiss = _annee;
            this.CatCommercial = _catComm;
            this.SerCom = _serComm;
            this.SerCom.ajouterCom(this);
        }

        // methods
        public int calculeAge() { return DateTime.Now.Year - this.AnneeNaiss; }
        public void compare(Commercial _c)
        {
            if (this.Nom == _c.Nom)
                Console.WriteLine("Ce commercial a le même nom de famille que l'autre.");
            else
                Console.WriteLine("Ce commercial n'a pas le même nom de famille que l'autre.");
        }
        public override string ToString()
        {
            return "Nom : " + this.Nom
                + "\nPrenom : " + this.Prenom
                + "\nAnnée de naissance : " + this.AnneeNaiss
                + "\nCe commercial a donc " + calculeAge() + " ans"
                + "\n" + this.CatCommercial;
        }
    }
}
