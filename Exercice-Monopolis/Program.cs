using System.Drawing;
using System.Text;
using Exercice_Monopolis.Enums;
using Exercice_Monopolis.Models;

namespace Exercice_Monopolis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Modifier la classe statique « De » pour que ses variables soient privées et qui devra implémenter
            //Les propriétés publiques:
            //◼ ValeurMin(int) – doit être supérieur à 0 et si la valeur est supérieur ou égale à la variable valeurMax, alors augmenter la valeurMax à la même valeur + 1
            //◼ ValeurMax(int) – doit être supérieur à 1 et si la valeur est inférieur ou égale à la variable valeurMin, alors la diminue à la même valeur – 1

            //2.Modifier la classe « Joueur » pour que ses variables soient remplacées par des auto - propriétés(nom pion), sauf pour la variable « position » et implémenter 
            //◼ Les propriétés publiques:
            //           1. ◼ Position(int) – Lecture seule

            //    2. ◼ Solde(int) – Lecture seule(argent)
            Joueur joueur = new Joueur() 
            {
                Nom = "Luc",
                Pion = Pions.DeACoudre
            };

            
            Console.WriteLine($"Bonjour, je suis {joueur.Nom}, je joue avec le pion {joueur.Pion} et je me trouve en position {joueur.Position}.");

            bool estDouble = joueur.Avancer();

            if (estDouble)
            {
                Console.WriteLine("Super un double!");
            }

            Console.WriteLine($"Bonjour, je suis {joueur.Nom}, je joue avec le pion {joueur.Pion} et je me trouve en position {joueur.Position} après avoir avancer avec les De.");
            
        }
    }
}
