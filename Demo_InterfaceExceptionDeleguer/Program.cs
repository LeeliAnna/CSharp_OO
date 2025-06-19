using Demo_InterfaceExceptionDeleguer.Models;
using Demo_InterfaceExceptionDeleguer.Structures;
using Demo_InterfaceExceptionDeleguer.Enums;
using Demo_InterfaceExceptionDeleguer.Exceptions;

namespace Demo_InterfaceExceptionDeleguer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Démo - Interfaces, Exceptions, Déléhgués");

            // Création de la poule
            Poule Lava = new Poule("Lava");
            //Déplacement de la poule
            Position emplacementDeLaPoule = Lava.Avancer(4, DIRECTION.Avant);

            //Affichage de la poule
            Console.WriteLine($"Ma poule se trouve désormais à l'emplacement x:{emplacementDeLaPoule.X} - y:{emplacementDeLaPoule.Y}");

            //Création d'un renard
            Renard goupil = new Renard("Ysengrin");
            //la poule est attentive au cris du renard
            // stockage dans le tableau d'evenement 
            goupil.ECrie += Lava.FuitPauvrePoule;

            goupil.VoitLaPoule();


            //On plante tout!!
            //DIRECTION Fausse = (DIRECTION)456;
            try
            {
                //Position emplacementAventDirectionFause = Lava.Avancer(4, Fausse);
                //Console.WriteLine($"Ma poule se trouve désormais à l'emplacement x:{Lava.} - y:{emplacementDeLaPoule.Y}");

            }
            catch (DirectionException de)
            {
                Console.WriteLine(de.ToString());
            }
            catch (Exception e) 
            {
                Console.WriteLine($"Message système : {e.Message}");
                Console.WriteLine($"Peux-tu faire en sorte d'utiliser correctement l'énumération prévue. CANARD!");
            }
        }
    }
}
