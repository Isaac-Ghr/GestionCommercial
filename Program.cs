using System;

namespace GestionClients
{
    class Program
    {
        static void Main(string[] args)
        {
            // bloc catégorie
            Categorie cat1 = new Categorie("CAT001", "Négoce");
            Categorie cat2 = new Categorie("CAT002", "Distribution");

            // bloc services
            Service ser1 = new Service("National");
            Service ser2 = new Service("International");

            // bloc commercial
            Commercial com1 = new Commercial("Ghorzi", "Isaac", 2004, cat1, ser1);
            Commercial com2 = new Commercial("Ghorzi", "Ismail", 2007, cat2, ser1);
            Commercial com3 = new Commercial("Dupont", "Alain", 2002, cat1, ser2);
            Console.WriteLine(com1); Console.WriteLine(com2); Console.WriteLine(com3);

            ser1.affiche();
            ser2.affiche();

            ser1.plusAge();

        }
    }
}
