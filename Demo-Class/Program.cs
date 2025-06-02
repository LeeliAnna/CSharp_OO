using Demo_Class.Models;

namespace Demo_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture maFerrari = new Voiture()
            {
                immatriculation = "2-ABC-123",
                couleur = "rouge",
                nbRoues = 4
            };

            //// Meme méthode pour instancier un objet
            //Voiture maPegeot = new Voiture();
            //maPegeot.immatriculation = "2-def-456";
            //maPegeot.couleur = "gris";
            //maPegeot.nbRoues = 4;

            Voiture laFraise = maFerrari;

            Console.WriteLine($"Voici ma voiture, elle est {maFerrari.couleur} et est immatriculée {maFerrari.immatriculation}.");
            Console.WriteLine($"Voici la voiture de mon fils, elle est {laFraise.couleur} et est immatriculée {laFraise.immatriculation}.");

            Console.WriteLine($"Je roule à pleine vitesse avec les {maFerrari.nbRoues} roues de ma voiture!");
            Console.WriteLine("BOOM!");
            maFerrari.nbRoues--;

            Console.WriteLine($"Ma voitur a maintenant {maFerrari.nbRoues} roues...");
            Console.WriteLine($"La voitur de mon fils a maintenant {laFraise.nbRoues} roues...");

        }


    }
    }
}
