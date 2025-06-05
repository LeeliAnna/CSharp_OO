using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice_Monopolis.Enums;

namespace Exercice_Monopolis.Models
{
    //1.Modifier la classe « Joueur » pour qu’elle implémente
    //◼ La variable privée:
    //◼ _proprietes(List<CasePropriete>)

    //◼ La propriété publique:
    //◼ Proprietes(CasePropriete[]) – Lecture seule
    //◼ Un constructeur qui initialise les propriétés : Nom, Pion par des paramètres; Solde à 1500, Position à 0 et initialiser une liste vide pour Proprietes.
    //◼ Les méthodes publiques:
    //◼ void EtrePaye(int montant) – Permet d’ajouter un montant au Solde du Joueur
    //◼ void Payer(int montant) – Permet de diminuer le solde du Joueur d’un montant renseigné en paramètre.Le Solde ne peut pas atteindre une valeur en dessous de 0.
    //◼ void AjouterPropriete(propriete casePropriete) – Permet d’ajouter la propriété dans la liste Proprietes seulement si celle-ci a comme propriétaire le joueur.
    internal class Joueur
    {
        public string Nom { get; set; }
        public Pions Pion { get; set; }
        private int _position = 0;
        private int _solde;
        private List<CasePropriete> _properietes;

        public int Position
        {
            get { return _position; }
            private set { _position = value; }
        }

        public int Solde
        {
            get { return _solde; }
            private set 
            { 
                _solde = value;
                
            }
        }

        internal List<CasePropriete> Properietes
        {
            get
            {
                return _properietes;
            }

            private set
            {
                _properietes = value;
            }
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

        public void Acheter(int prix)
        {
            Solde -= prix;
        }

    }
}
