using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Monopolis.Models
{
    /*1. Créer la classe « Case » qui devra implémenter
    ◼ La variable membre privée :
    ◼ _visiteurs (List<Joueur>)
    ◼ Les propriétés publiques :
    ◼ Nom (string) – Lecture seule
    ◼ Visiteurs (Joueur[ ]) – Lecture seule
    ◼ Un constructeur qui initialise : la propriété « Nom » à l’aide d’un paramètre et initialise une List<Joueur> vide pour la variable _visiteurs.
      1. Faire hériter la classe « Case » de la classe « CasePropriete »
      ◼ Enlever les membres communs de la classe parent.
     * 
     * 
     */
    internal class Case
    {
        private List<Joueur> _visiteurs;

        public string Nom { get; private set; }
        public Joueur[] Visiteur
        {
            get 
            {
                return _visiteurs.ToArray();
            }
            private set
            {

            } 
        }

        public Case(string nom)
        {
            Nom = nom;
            _visiteurs = new List<Joueur>();
        }

        /*
        ◼ Les méthodes publiques :
            ◼ void AjouterVisiteur (Joueur visiteur) – Permet de regrouper les visiteurs d’une même case.
            ◼ void RetirerVisiteur (Joueur visiteur) – Permet de retirer un joueur de la liste des visiteurs de cette case.
        */

        public void AJouterVisiteur(Joueur visiteur) 
        {
            if (_visiteurs.Contains(visiteur)) return; //Message d'erreur
            _visiteurs.Add(visiteur);
        }

        public void RetirerVisiteur(Joueur visiteur) 
        {
            if (!_visiteurs.Remove(visiteur)) return; //Message exception
        }

    }
}
