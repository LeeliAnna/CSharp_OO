using Démo_enumeration.Models;
using Démo_enumeration.Enums;

namespace Démo_enumeration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Trafficlight feu1 = new Trafficlight() { 
            //    colors = ["vert", "orange", "rouge"],
            //currentColor = 0};

            //feu1.colors[0] = "bleu";

            Trafficlight feu1 = new Trafficlight()
            {
                currentColor = TrafficLightColors.vert
            };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Actuellement le feu est {feu1.currentColor}.");
                feu1.ChangeColor(); 
            }

            

        }
    }
}
