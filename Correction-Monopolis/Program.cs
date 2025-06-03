using Correction_Monopolis.Enums;

namespace Correction_Monopolis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez choixir un pion :");
            string[] pionNames = Enum.GetNames<Pions>();
            //Pions[] pions = Enum.GetValues<Pions>();

            foreach (string pionName in pionNames)
            {
                Console.WriteLine($"\t - {pionName}");   
            }

            Console.WriteLine("Quel pion choisiez vous? ");
            string userInput = Console.ReadLine();

            Pions choice = Enum.Parse<Pions>(userInput);

        }
    }
}
