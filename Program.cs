using ProjetConsoleWild.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsoleWild
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création du menu principal
            // Classe nomDeMonObjet = new Classe
            // Instanciation spécifique au C#
            MenuPrincipal menuPrincipal = new MenuPrincipal
            {
                Titre = "Menu principal",
                Choix1 = "1. Eleve",
                Choix2 = "2. Cours",
                Choix3 = "3. Quitter" };

            MenuEleve menuEleve = new MenuEleve
            {
                Titre = "Menu eleve",
                Choix1 = "1. Lister les élèves",
                Choix2 = "2. Créer un nouvel élève",
                Choix3 = "3. Consulter un élève existant",
                Choix4 ="4. Ajouter une note et une appréciation pour un cours sur un élève existant",
                Choix5 ="5. Revenir au menu principal"
            };

            MenuCours menuCours = new MenuCours
            {
                Titre = "Menu cours",
                Choix1 = "1. Lister les cours existants",
                Choix2 = "2. Ajouter un nouveau cours au programme",
                Choix3 = "3. Supprimer un cours par son identifiant",
                Choix4 = "4. Revenir au menu principal",
                

            };
            string menuActuel = menuPrincipal.Titre;
            string choixUtilisateur;


            while(menuActuel != "Quitter") {
                switch (menuActuel)
                {
                    case "Menu principal":
                        menuPrincipal.afficherMenuPrincipal(); // Affichage du menu principal avec les 3 choix
                        choixUtilisateur = demanderChoixUtilisateur(); // Readline : récupération du choix de l'utilisateur
                        switch (choixUtilisateur) {
                            case "1": // Navigation vers menu eleve
                                menuActuel = "Menu eleve";
                                break;
                            case "2": // Navigation vers menu cours
                                menuActuel = "Menu cours";
                                break;
                            case "3": // Quitter l'application
                                menuActuel = "Quitter";
                                break;
                            default:
                                break;
                        }
                        break;

                    case "Menu eleve":
                        menuEleve.afficherMenuEleve(); // Affichage du menu eleve avec les 5 choix
                        choixUtilisateur = demanderChoixUtilisateur(); // Readline : récupération du choix de l'utilisateur
                        switch (choixUtilisateur)
                        {
                            case "1":
                                // TODO
                                break;
                            case "2": 
                                // TODO
                                break;
                            case "3": 
                                // TODO
                                break;
                            case "4":
                                // TODO
                                break;
                            case "5": // Navigation vers menu principal
                                menuActuel = "Menu principal";
                                break;  
                            default:
                                break;
                        }
                        break;

                    case "Menu cours":
                        menuCours.afficherMenuCours(); // Affichage du menu cours avec les 4 choix
                        choixUtilisateur = demanderChoixUtilisateur(); // Readline : récupération du choix de l'utilisateur

                        switch (choixUtilisateur)
                        {
                            case "1":
                                // TODO
                                break;
                            case "2":
                                // TODO
                                break;
                            case "3":
                                // TODO
                                break;
                            case "4":
                                menuActuel = "Menu principal";
                                break;


                        }
                        break;



                }


                Console.WriteLine("\n-------------------------\n");
            }



        }

        private static string demanderChoixUtilisateur() {
            Console.WriteLine("Entrez votre choix:");
            return Console.ReadLine();
        }
    }
}
