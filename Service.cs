using System;
using System.Collections.Generic;
using System.Text;

namespace GestionClients
{
    class Service
    {
        // attributes
        private string nomService;
        private Commercial[] tabCom;
        private int effectif;
        
        // accesseurs
        public string NomService { get => nomService; set => nomService = value; }
        public int Effectif { get => effectif; set => effectif = value; }
        internal Commercial[] TabCom { get => tabCom; set => tabCom = value; }

        // constructors
        public Service() { this.TabCom = new Commercial[10]; }
        public Service(string _nom)
        {
            this.NomService = _nom;
            this.Effectif = 0;
            this.TabCom = new Commercial[10];
        }

        // methods
        internal void ajouterCom(Commercial _c) { if (this.Effectif < this.TabCom.Length) this.TabCom[this.Effectif] = _c; ++this.Effectif; }
        public void plusAge()
        {
            int _max = 0;
            Commercial _lePlusAge = new Commercial();
            foreach (Commercial _com in this.TabCom) { if (_com != null && _com.calculeAge() > _max) { _max = _com.calculeAge(); _lePlusAge = _com; } }
            Console.WriteLine("Le commercial le plus agé est " + _lePlusAge.Nom + " " + _lePlusAge.Prenom + " qui est agé de " + _lePlusAge.calculeAge() + " ans");
        }
        public void affiche() { Console.WriteLine("\nListe des commerciaux pour le service " + this.NomService); foreach (Commercial _com in this.TabCom) if (_com != null) Console.WriteLine("\n" + _com); }

    }
}
