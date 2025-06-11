using Demo_Heritage.Models;

namespace Demo_Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forme f = new Forme("Rouge",2);

            Rectangle r = new Rectangle("Bleu",3,3,5);

            Cercle c = new Cercle("Green",3,5);

            Carre c2 = new Carre("Jaune",2,5);

        }
    }
}
