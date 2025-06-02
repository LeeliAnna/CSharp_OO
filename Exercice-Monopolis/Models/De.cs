using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Exercice_Monopolis.Models
{
    //2.Créer une classe statique « De » qui devra implémenter
    //◼ Les variables membres:
    //◼ valeurMin(int)
    //◼ valeurMax(int)
    //◼ rng(Random)
    //◼ La méthode publique:
    //◼ int[] Lancer(int nbDes) – Permet de lancer des dés, nbDes indiquant le nombre de dés. La valeur de retour correspond aux résultats de tout les dés.
    internal class De
    {
        public int valeurMin;
        public int valeurMax;
        public static Random rnd;

        public int[] Lancer(int nbDes)
        {
            int[] tous = new int[nbDes];

            for (int i = 0; i < nbDes; i++)
            {
                tous[i] = rnd.Next(valeurMin, valeurMax + 1);
            }
            return tous;
        }
    }
}
