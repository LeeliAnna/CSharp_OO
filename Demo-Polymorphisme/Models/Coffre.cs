using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Polymorphisme.Models
{
    internal class Coffre
    {
        public InventaireItem Contenu { get; private set; }

        public Coffre(InventaireItem contenu)
        {
            Contenu = contenu;
        }

        public Coffre(InventaireItem[] contenus)
        {
            Random rng = new Random();
            // Choisi un element aléatoirement parmis la longeueu d'un tableau d'elements
            Contenu = contenus[rng.Next(contenus.Length)];
        }

        public void ViderCoffre()
        {
            Contenu = null;
        }

    }
}
