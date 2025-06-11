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

            Joueur joueur = new Joueur
            (
                userName,
                choice
            );


            Console.WriteLine($"Bonjour, je suis {joueur.Nom}, je joue avec le pion {joueur.Pion} et je me trouve en position {joueur.Position}.");

            bool estDouble = joueur.Avancer();

            if (estDouble)
            {
                Console.WriteLine("Super un double!");
            }

            Console.WriteLine($"Bonjour, je suis {joueur.Nom}, je joue avec le pion {joueur.Pion} et je me trouve en position {joueur.Position} après avoir avancer avec les De.");

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

            CasePropriete[] cases =
            {
                new CasePropriete("Patio", Couleurs.BleuCiel, 20),
                new CasePropriete("Accueil", Couleurs.BleuCiel, 23),
                new CasePropriete("Bureau Sonia", Couleurs.Marron, 26),
                new CasePropriete("Bureau Nicole", Couleurs.Marron, 26),
                new CasePropriete("Bureau Laure", Couleurs.Marron, 30)
            };

            Jeu monopily = new Jeu(cases);
            Console.WriteLine($"Votre plateau compte {monopily.Plateau.Length} cases.");

            //cases.Add(new CasePropriete("WC Fille", Couleurs.Violet, 32));
            Console.WriteLine($"Votre plateau compte {monopily.Plateau.Length} cases.");

        }
    }
}
