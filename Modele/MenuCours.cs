using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsoleWild.Modele
{
    public class MenuCours
    {

        // Titre, Choix1, Choix2, Choix3 ATTRIBUT
        public string Titre { get; set; }

        public string Choix1 { get; set; }

        public string Choix2 { get; set; }
        public string Choix3 { get; set; }

        public string Choix4 { get; set; }





        public void afficherMenuCours()
        {
            Console.WriteLine(Titre);
            Console.WriteLine(Choix1);
            Console.WriteLine(Choix2);
            Console.WriteLine(Choix3);
            Console.WriteLine(Choix4);
           


        }

















    }
}
