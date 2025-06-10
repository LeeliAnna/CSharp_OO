using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Indexeur.Models
{
    internal class Equipement
    {
        public string Nom { get; set; }
        public string Couleur { get; set; }
        public int Puissance { get; set; }

        /// <summary>
        /// Additionner les puissances
        /// </summary>
        /// <param name="e1">premier equipement</param>
        /// <param name="e2">deuxieme equipement</param>
        /// <returns></returns>
        public static int operator + (Equipement e1, Equipement e2)
        {
            return e1.Puissance + e2.Puissance;
        }

        /// <summary>
        /// Additionner un int avec un equipement
        /// </summary>
        /// <param name="puissance">puissance en int</param>
        /// <param name="e1">nouvel equipement a ajouter</param>
        /// <returns></returns>
        public static int operator + (int puissance, Equipement e1) 
        {
            return puissance + e1.Puissance;
        }

    }
}
