using Demo_static.Models;

namespace Demo_static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Formation games = new Formation()
            {
                nom = "Games 25",
                eleves = new List<string>(["Manon", "Begüm", "Estelle", "Gaëlle", "Lyst"])
            };

            Formation.centre = "Interface3";

            Formation wad = new Formation()
            {
                nom = "Wad 25",
                eleves = new List<string> ( ["Laura", "Emilie", "Yulia", "Anaïs", "Siham", "Tran"] )
            };

            //Formation.Description();
            //Console.WriteLine("----- Les voici : -----");
            //games.Decrire();
            //Console.WriteLine("--------------------------------");
            //wad.Decrire();

            int result = Mathematique.MettreAuCarre(3);
            ConsoleRainbow.WriteLine($"3 au carré donne : {result}");
        }
    }
}
