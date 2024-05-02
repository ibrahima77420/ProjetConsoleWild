using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsoleWild
{
    public class Eleve
    {
  //Lister eleves, cree un nouvelle eleve, consilter un eleve existant, ajouter une note 
  //revenir au menu principal 

        public  string Prenom { get; set; }
        public string Nom { get; set; }
        public DateTime DateNaissance { get; set; }
        public List<Note> Notes { get; set; }

        public int Identifiant { get; set; }



        //methode 

        public static void afficherMenuEleve(string choixUtilisateur)
        {

            switch (choixUtilisateur)
            {
                case "1":
                //    ListerEleves();
                    break;

                case "2":
                 //   CreerNouvelEleve();
                    break;

                case "3":
                  //  AjouterNoteEtAppreciation();
                    break;

                case "4":
                    Console.WriteLine("Revenir au menu principal");
                    // Il peut être utile ici d'ajouter une logique pour revenir au menu principal
                    break;

                default:
                    Console.WriteLine("Je n'ai pas compris");
                    break;
            }








        }






        public static Eleve creerNouvelEleve()
        {
            Console.WriteLine("Création d'un nouvel élève :");

            Console.Write("Entrez le prénom de l'élève : ");
            string prenom = Console.ReadLine();

            Console.Write("Entrez le nom de l'élève : ");
            string nom = Console.ReadLine();

            Console.Write("Entrez la date de naissance de l'élève (au format jj/mm/aaaa) : ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dateNaissance))
            {
                // Créer un nouvel objet Eleve avec les informations saisies
                Eleve nouvelEleve = new Eleve
                {
                    Prenom = prenom,
                    Nom = nom,
                    DateNaissance = dateNaissance
                };

                // Retourner le nouvel élève créé
                return nouvelEleve;
            }
            else
            {
                Console.WriteLine("Format de date incorrect. Veuillez saisir la date au format jj/mm/aaaa.");
                return null;
            }
        }





























    }

    public class Note
    {
    }
}
