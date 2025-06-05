using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace Exo_recap_fondement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region Exercice 1 - Distributeur de boissons
            ////1.À l’aide de tableaux, dans une application console, simulez un distributeur de boisson.
            ////Le distributeur peut distribuer 8 types de boissons différentes. Il connait la quantité et le
            ////nom de chacune des boissons, auxquelles on a attribué un numéro permettant de
            ////sélectionner la boisson.
            ////Le distributeur distribue tant qu’il a encore des boissons en stock.Si la boisson n’est pas
            ////disponible, nous l’indiquons à l’utilisateur.Lorsqu’il n’y a plus de boisson dans le distributeur,
            ////celui-ci s’arrête.
            //string[] boissons = new string[] { "eau", "jus de pomme", "coca", "fanta", "sprite", "schweps", "pepsi", "monster" };
            //int[] quantites = new int[] { 10, 10, 10, 10, 10, 10, 10, 10 };
            ////int[] quantites = new int[] { 1, 1, 1, 1, 1, 1, 1, 1 };
            //int choixUtilisateur = 0;

            //Console.WriteLine("-------- Distributeur à boissons --------");
            //AfficherTab(boissons, quantites);
            //Console.WriteLine("Veuillez choisir une boisson : ");

            //do
            //{
            //    int.TryParse(Console.ReadLine(), out choixUtilisateur);
            //    Console.Clear();
            //    if (choixUtilisateur < 1 || choixUtilisateur > boissons.Length)
            //    {
            //        Console.WriteLine("⚠️⚠️⚠️ Choix invalide. ⚠️⚠️⚠️");
            //    }
            //    else
            //    {
            //        choixUtilisateur--;
            //        if (CheckQuantite(quantites, choixUtilisateur))
            //        {
            //            quantites[choixUtilisateur]--;
            //            Console.WriteLine($" ✅ Préparation de votre {boissons[choixUtilisateur]}.");
            //            Console.WriteLine();
            //            Console.SetCursorPosition(12, 2);
            //            Console.WriteLine("...");
            //            Console.WriteLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Il n'y a plus de {boissons[choixUtilisateur]}");
            //        }
            //    }

            //    Console.WriteLine("Veuillez choisir une boisson : ");
            //    AfficherTab(boissons, quantites);

            //} while (!CheckDistributeurVide(quantites));
            //Console.Clear();
            //Console.WriteLine("-----------------------------------------");
            //for (int i = 0; i < boissons.Length + 1; i++)
            //{
            //    if (i == (boissons.Length + 1) / 2) Console.WriteLine("|\t  Distributeur vide.\t\t|");
            //    else Console.WriteLine("|\t\t\t\t\t|");
            //}

            //Console.WriteLine("-----------------------------------------");
            #endregion

            #region Exercice 2 - Jeu du Morpion
            //2.À l’aide d’un tableau matriciel, dans une application console, recréez le jeu du Morpion(TicTac-Toe).
            //Dans une grille de 3 cases sur 3, l’utilisateur devra jouer contre l’ordinateur pour effectuer en
            //premier une ligne de 3 symboles(O ou X).Le joueur avec le X commence, choisissez
            //aléatoirement si il s’agit de l’ordinateur ou de l’utilisateur.Chacun son tour, les joueurs
            //placent un symbole. 

            const int TAILLE = 3;

            int[,] grille = new int[TAILLE, TAILLE];

            grille[2, 0] = 1;
            grille[2, 1] = 2;

            AffachageGrille(grille);

            #endregion

        }

        #region Méthodes - Distributeur de boissons
        static bool CheckDistributeurVide(int[] quantite)
        {
            int compte = 0;
            foreach (int valeur in quantite)
            {
                if (valeur == 0) compte++;
            }

            if (compte == quantite.Length) return true;
            return false;
        }

        static bool CheckQuantite(int[] quantites, int nb)
        {
            if (quantites[nb] <= 0) return false;
            return true;
        }

        static void AfficherTab(string[] tabString, int[] tabInt)
        {
            Console.WriteLine("-----------------------------------------");
            for (int i = 0; i < tabString.Length; i++)
            {
                if (i == 1 || i == 5 || i == 7) Console.WriteLine($"|\t{i + 1} - {tabString[i]} : {tabInt[i]}\t\t|");
                else Console.WriteLine($"|\t{i + 1} - {tabString[i]} : {tabInt[i]}\t\t\t|");
            }
            Console.WriteLine("-----------------------------------------");

        }
        #endregion

        #region Méthodes - Jeux du Morpion
        static void AffachageGrille(int[,] tab)
        {
            for (int ligne = 0; ligne < tab.GetLength(0); ligne++)
            {
                for (int colonne = 0; colonne < tab.GetLength(1); colonne++)
                {
                    if (tab[ligne,colonne] == 0) Console.Write($" . ");
                    else if (tab[ligne,colonne] == 1) Console.Write(" O ");
                    else if (tab[ligne, colonne] == 2) Console.Write(" X ");
                }
                Console.WriteLine();
            }
        }

        static bool VerifiactionGagantHorizontal() { return true; }

        static bool VerifiactionGagantVerticale() { return true; }

        static bool VerifiactionGagantDiagonal() { return true; }

        #endregion

    }
}
