using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correction_Monopolis.Models
{
    internal static class De
    {
        private static int _valeurMin = 1;
        public static int ValeurMin { 
            get
            { 
                return ValeurMin; 
            } 
            set
            {
                if (value > 0)
                {
                    _valeurMin = value;
                    if (value >= ValeurMax)
                    {
                        ValeurMax = value + 1;
                        //ValeurMax = _valeurMin + 1;

                    }
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
                if (value > 1)
                {
                    _valeurMax = value;
                    if (value <= ValeurMin) 
                    {
                        ValeurMin = value - 1;
                        //ValeurMin = _valeurMax - 1;
                    }
                }
            }
        }

        

        public static Random rng = new Random();


        public static int[] Lancer(int nbDes)
        {
            int[] result = new int[nbDes];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = rng.Next(ValeurMin, ValeurMax + 1);
            }

            return result;
        }
    }
}
