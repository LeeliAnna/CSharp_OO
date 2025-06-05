using demo_encapsulation.Models;
using System.Diagnostics;
using System.Text;

namespace demo_encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Login monlogin = new Login();
            monlogin.email = "tutu@tutu.be";
            monlogin.ChangePassword("Test1234=\r");


            //Console.WriteLine($"Veuillez introduir votre email :");
            //monlogin.email = Console.ReadLine();
            //Console.WriteLine("Veuillez introduir votre mot de passe : ");

            //ConsoleKeyInfo keyInfo;
            //string password = "";
            //do
            //{
            //    // dans ReadKey si on met true, il va cacher ce qui est entrer au clavier. Par défaut false
            //    keyInfo = Console.ReadKey(true);

            //    // Récupère la lettre et la concatène au password
            //    password += keyInfo.KeyChar;
            //    Console.Write("*");

            //}
            //while (keyInfo.Key != ConsoleKey.Enter);
            //monlogin.ChangePassword(password);

            Console.WriteLine($"Veuillez introduir votre email :");
            string email = Console.ReadLine();
            Console.WriteLine("Veuillez introduir votre mot de passe : ");

            ConsoleKeyInfo keyInfo;
            string password = "";
            do
            {
                // dans ReadKey si on met true, il va cacher ce qui est entrer au clavier. Par défaut false
                keyInfo = Console.ReadKey(true);

                // Récupère la lettre et la concatène au password
                password += keyInfo.KeyChar;
                Console.Write("*");

            }
            while (keyInfo.Key != ConsoleKey.Enter);
            Console.WriteLine();

            bool isConnected = monlogin.CheckUser(email, password);

            if (isConnected) 
            {
                Console.WriteLine("✅ Bienvenue!");
            }
            else
            {
                Console.WriteLine("❌ Compt bloqué!");
            }

        }
    }
}
