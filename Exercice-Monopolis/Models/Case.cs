using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Monopolis.Models
{
    internal abstract class Case
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

        public void AJouterVisiteur(Joueur visiteur) 
        {
            if (_visiteurs.Contains(visiteur)) return; //Message d'erreur
            _visiteurs.Add(visiteur);
        }

        public void RetirerVisiteur(Joueur visiteur) 
        {
            if (!_visiteurs.Remove(visiteur)) return; //Message exception
        }

        public abstract void Activer(Joueur visiteur);

    }
}
