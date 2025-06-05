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
