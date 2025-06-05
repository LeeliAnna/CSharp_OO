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
        public string Nom {  get; set; }
        public Pions Pion { get; set; }

        private int _position = 0;

        private int _solde;

        public int Position
        {
            get
            {
                return _position;
            }
            private set
            {
                _position = value;
            }
        }

        public int Solde
        {
            get
            {
                return _solde;
            }
            private set
            {
                if (value < 0)
                {
                    _solde = 0;
                    Console.WriteLine("Ceci sera remplacer lutard par une excepetion");
                }
                else
                {
                    _solde = value;
                }
            }
        }

        /// <summary>
        /// Méthode permetant d'effectuer un déplacement sur le plateau de jeu en fonction des limites citées
        /// </summary>
        /// <returns>retourne true si le joueur a fait un jet de de double</returns>
        public bool Avancer()
        {
            De.ValeurMin = 1;
            De.ValeurMax = 6;

            int[] resultDes = De.Lancer(2);
            Position += resultDes[0] + resultDes[1];
            return resultDes[0] == resultDes[1];
        }
    }
}
