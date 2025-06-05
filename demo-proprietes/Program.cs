using demo_proprietes.Models;
using System.Text;

namespace demo_proprietes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Personne p1 = new Personne();
            p1.Nom = "skywalker";
            p1.Prenom = "Luc";
            p1.DateNaissance = new DateOnly(1987, 9, 27);

            Console.WriteLine($"Bonjour, je m'appel {p1.NomComplet}, j'ai {p1.Age} ans. ");
            p1.JoyeuxAnniversaire();
        }
    }
}
