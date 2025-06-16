using Demo_Abstract.Models;

namespace Demo_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal chien = new Chien("Leeloo");
            //chien.Crier();
            //Console.WriteLine();

            //Animal pigeaon = new Pigeon("Bob");
            //pigeaon.Crier();
            //Console.WriteLine();

            List<Animal> pnj = new List<Animal>()
            {
                new Chien("Leeloo"),
                new Pigeon("Bob"),
                new Poule("Ginger"),
                new Mesange("Le piaf")
            };

            Console.Write($"En me promenant, j'ai entendu ");
            pnj[new Random().Next(pnj.Count)].Crier();
            Console.WriteLine();
        }
    }
}
