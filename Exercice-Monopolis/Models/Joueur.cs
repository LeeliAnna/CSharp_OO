using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice_Monopolis.Enums;

namespace Exercice_Monopolis.Models
{
    //3.Créer une classe « Joueur » qui devra implémenter
    //◼ Les variables membres:
    //◼ nom(string)
    //◼ pion(Pions)
    //◼ position(int) – Position sur le plateau de jeu
    //◼ La méthode publique:
    //◼ bool Avancer() – Le joueur lance deux dés et avance de la quantité de cases équivalant au total des dés. Indique en retour si le joueur a obtenu un double.

    //2.Modifier la classe « Joueur » pour que ses variables soient remplacées par des auto - propriétés(nom pion), sauf pour la variable « position » et implémenter 
    //◼ Les propriétés publiques:
    //           1. ◼ Position(int) – Lecture seule

    //    2. ◼ Solde(int) – Lecture seule(argent)
    internal class Joueur
    {
        public string Nom { get; set; }
        public Pions Pion { get; set; }
        private int _position = 0;

        public int Position
        {
            get { return _position; }
            private set { _position = value; }
        }

        private int _solde;

        public int Solde
        {
            get { return _solde; }
            private set { _solde = value; }
        }




        public bool Avancer()
        {
            int[] jetDe = De.Lancer(2);
            for (int i = 0; i < jetDe.Length; i++)
            {
                De.ValeurMin = 1;
                De.ValeurMax = 6;
                _position += jetDe[i];
                if (i != jetDe.Length - 1 && jetDe[i] == jetDe[i + 1])
                {
                    return true;
                }
            }
            return false;
        }

    }
}
