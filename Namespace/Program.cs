//using Inventaire;
//using Namespace;
using Namespace.Inventaire;
namespace Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Sans l'import de l'inventaire grace au using
            //Inventaire.Item ObjetInventaire = new Inventaire.Item();
            //ObjetInventaire.name = "Pépite";
            //ObjetInventaire.value = 5000;

            //Console.WriteLine($"Dans mon sac, j'ai une {ObjetInventaire.name} de {ObjetInventaire.value} Pokédollars !");

            // Avec le using Inventaire
            Item ObjetInventaire = new Item();
            ObjetInventaire.name = "Pépite";
            ObjetInventaire.value = 5000;

            Console.WriteLine($"Dans mon sac, j'ai une {ObjetInventaire.name} de {ObjetInventaire.value} Pokédollars !");
        }
    }
}



