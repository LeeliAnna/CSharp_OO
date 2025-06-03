using Correction_Monopolis.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correction_Monopolis.Models
{
    internal class Joueur
    {
        public string nom;
        public Pions pion;
        public int position = 0;

        public bool Avancer()
        {
            De.valeurMin = 1;
            De.valeurMax = 6;

            int[] resultDes = De.Lancer(2);
            position += resultDes[0] + resultDes[1];
            return resultDes[0] == resultDes[1];
        }
    }
}
