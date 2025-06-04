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

    //1.Modifier la classe statique « De » pour que ses variables soient privées et qui devra implémenter
    //Les propriétés publiques:
    //◼ ValeurMin(int) – doit être supérieur à 0 et si la valeur est supérieur ou égale à la variable valeurMax, alors augmenter la valeurMax à la même valeur + 1
    //◼ ValeurMax(int) – doit être supérieur à 1 et si la valeur est inférieur ou égale à la variable valeurMin, alors la diminue à la même valeur – 1
    internal static class De
    {
        private static int _valeurMin = 1;

        public static int ValeurMin
        {
            get 
            { 
                return _valeurMin;
            }
            set 
            {
                _valeurMin = value;
                if (value <= 0)
                {
                    _valeurMin = 0;
                }
                else if (value >= _valeurMax)
                {
                    _valeurMax += 1; 
                }
            }
        }

        private static int _valeurMax = 6;

        public static int ValeurMax
        {
            get 
            {
                return _valeurMax;
            }
            set 
            {
                _valeurMax = value;
                if(value < 1)
                {
                    _valeurMax = 1;
                }
                else if (value <= _valeurMin)
                {
                    _valeurMin -= 1;
                }

            }
        }

        public static Random rnd = new Random();

        public static int[] Lancer(int nbDes)
        {
            int[] tous = new int[nbDes];

            for (int i = 0; i < nbDes; i++)
            {
                tous[i] = rnd.Next(_valeurMin, _valeurMax + 1);
            }
            return tous;
        }
    }
}
