using System;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Linq;
using Exercice_Monopolis.Enums;
using Exercice_Monopolis.Models;

namespace Exercice_Monopolis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Initialisation du plateau
            CasePropriete[] cases =
            {
                new CasePropriete("Patio", Couleurs.Marron, 20),
                new CasePropriete("Accueil", Couleurs.Marron, 23),

                new CasePropriete("Ascenceur Gauche", Couleurs.BleuCiel, 26),
                new CasePropriete("Ascenceur Droit", Couleurs.BleuCiel, 26),
                new CasePropriete("Toilette RDC", Couleurs.BleuCiel, 30),

                new CasePropriete("Couloir 4eme étage", Couleurs.Violet, 32),
                new CasePropriete("Couloir 5eme étage", Couleurs.Violet, 32),
                new CasePropriete("Toilettes 5eme étage", Couleurs.Violet, 32),

                new CasePropriete("Classe des WAD", Couleurs.Orange, 42),
                new CasePropriete("Classe des WEB", Couleurs.Orange, 42),
                new CasePropriete("Classe des Games", Couleurs.Orange, 48),

                new CasePropriete("Bureau Sonia", Couleurs.Bleu, 56),
                new CasePropriete("Bureau Nicole", Couleurs.Bleu, 56),
                new CasePropriete("Bureau Laure", Couleurs.Bleu, 60)
            };

            Jeu monopily = new Jeu(cases);
            Console.WriteLine($"Votre plateau compte {monopily.Plateau.Length} cases.");

            //cases.Add(new CasePropriete("WC Fille", Couleurs.Violet, 32));
            //Console.WriteLine($"Votre plateau compte {monopily.Plateau.Length} cases.");
            #endregion


            #region Initialisation de la liste des joueurs
            //Joueur joueur = new Joueur() 
            //{
            //    Nom = "Luc",
            //    Pion = Pions.DeACoudre
            //};

            //Joueur joueur = new Joueur("Luc", Pions.DeACoudre);
            //{
            //Nom = "Luc",
            //Pion = Pions.DeACoudre
            //};
            // Boucle pour demander combien de joueurs vont jouer

            int nbJoueurs;
            do
            {
                Console.WriteLine("Combien de joueurs jouent ? (entre 2 et 6)");
            } while (!int.TryParse(Console.ReadLine(), out nbJoueurs) || nbJoueurs < 2 || nbJoueurs > 6);

            //Ajout de joueur tant le nombre n'est pas égale au nombre de joueur désirer
            do
            {
                Console.WriteLine("Joueur, veuillez indiquez votre nom :");
                string userName = Console.ReadLine();

                Console.WriteLine("Veuillez choixir votre pion :");
                string[] pionNames = Enum.GetNames<Pions>();

                foreach (string pion in pionNames)
                {
                    Console.WriteLine($"\t- {pion}");
                }

                Console.WriteLine("Quel pion choisissez-vous? ");
                string userInput = Console.ReadLine();
                Pions choice = Enum.Parse<Pions>(userInput);

                // Ajout d'un joueur par la méthode d'ajout du joueur de la classe jeu
                monopily.AjouterJoueur(userName, choice);
            } while (monopily.Joueurs.Length < nbJoueurs); 
            #endregion



            int tourJoueur = 0;
            while (tourJoueur < 40)
            {
                // permet de retrouver le joueur avec seulement des identifiants possibles
                Joueur joueurCourant = monopily.Joueurs[tourJoueur % monopily.Joueurs.Length];
                CasePropriete caseCourrante = monopily[joueurCourant.Position];

                //Traitement du tour
                Console.WriteLine($"Bonjour, je suis {joueurCourant.Nom}, je joue avec le pion {joueurCourant.Pion} et je me trouve en position {caseCourrante.Nom}.");

                bool estDouble = joueurCourant.Avancer();
                caseCourrante = monopily[joueurCourant.Position];

                while (estDouble)
                {
                    Console.WriteLine("Super un double!");
                    //Ajouter de l'argent
                    //joueurCourant.EtrePaye(200);
                    //joueurCourant = joueurCourant + 200;
                    //joueurCourant += 200;
                    Console.WriteLine($"Bonjour, je suis {joueurCourant.Nom}, je joue avec le pion {joueurCourant.Pion} et je me trouve en position {caseCourrante.Nom} après avoir avancer avec les Dés.");
                    estDouble = joueurCourant.Avancer();
                    caseCourrante = monopily[joueurCourant.Position];
                }

                Console.WriteLine($"Bonjour, je suis {joueurCourant.Nom}, je joue avec le pion {joueurCourant.Pion} et je me trouve en position {caseCourrante.Nom} après avoir avancer avec les Dés.");

                tourJoueur++;
            }

            #region Exemples et autres utilisation de mes classes
            // Enum contenant un string
            ////string laCouleur = "BleuCiel";
            //Couleurs maCouleur = (Couleurs)Enum.Parse(typeof(Couleurs), laCouleur);
            //Console.WriteLine(maCouleur);
            //Console.WriteLine((int)maCouleur);

            //// Attention à l'enum contenant un INT
            //string laCouleur = "BleuCiel";
            //int couleurBleuCiel = 1;
            //Couleurs maCouleur = (Couleurs)couleurBleuCiel;
            //Console.WriteLine(maCouleur);
            //Console.WriteLine((int)maCouleur);

            //Joueur joueur1 = new Joueur();
            //CasePropriete maCase = new CasePropriete();
            //joueur1.Properietes = maCase;

            //List<CasePropriete> cases = new List<CasePropriete>()
            //{
            //    new CasePropriete("Patio", Couleurs.BleuCiel, 20),
            //    new CasePropriete("Accueil", Couleurs.BleuCiel, 23),
            //    new CasePropriete("Bureau Sonia", Couleurs.Marron, 26),
            //    new CasePropriete("Bureau Nicole", Couleurs.Marron, 26),
            //    new CasePropriete("Bureau Laure", Couleurs.Marron, 30)
            //}; 
            #endregion



        }
    }
}
