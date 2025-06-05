using Demo_constructeur.Models;
using System.Globalization;

namespace Demo_constructeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne quelconque = new Personne();

            Console.WriteLine($"{quelconque.Nom} | {quelconque.Prenom} | {quelconque.Age}");

            Personne deuxieme = new Personne("Alba", "Jessica");
            Console.WriteLine($"{deuxieme.Nom} | {deuxieme.Prenom} | {deuxieme.Age}");

            Personne nouvelle = new Personne("PtiteGoutte", "Justine");
            Console.WriteLine($"{nouvelle.Nom} | {nouvelle.Prenom} | {nouvelle.Age}");

            Personne troisieme = new Personne("Coucou", "Hibou", new DateOnly(1978, 03, 19));
            Console.WriteLine($"{troisieme.Nom} | {troisieme.Prenom} | {troisieme.Age}");

        }
    }
}
