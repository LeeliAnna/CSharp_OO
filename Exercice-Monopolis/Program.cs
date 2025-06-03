using System.Text;
using Exercice_Monopolis.Models;

namespace Exercice_Monopolis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Joueur joueur = new Joueur() 
            {
                nom = "Luc",
                pion = Pions.DeACoudre,
                position = 2
            };

            De.valeurMin = 1;
            De.valeurMax = 6;

            bool estDouble = joueur.Avancer();
            Console.WriteLine(estDouble);
            
        }
    }
}
