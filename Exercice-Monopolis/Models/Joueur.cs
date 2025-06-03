using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Monopolis.Models
{
    //3.Créer une classe « Joueur » qui devra implémenter
    //◼ Les variables membres:
    //◼ nom(string)
    //◼ pion(Pions)
    //◼ position(int) – Position sur le plateau de jeu
    //◼ La méthode publique:
    //◼ bool Avancer() – Le joueur lance deux dés et avance de la quantité de cases équivalant au total des dés. Indique en retour si le joueur a obtenu un double.
    internal class Joueur
    {
        public string nom;
        public Pions pion;
        public int position;


        public bool Avancer()
        {
            int[] jetDe = De.Lancer(2);
            for (int i = 0; i < jetDe.Length; i++)
            {

                position += jetDe[i];
                if (i != jetDe.Length - 1 && jetDe[i] == jetDe[i + 1])
                {
                    return true;
                }
            }
            return false;
        }

    }
}
