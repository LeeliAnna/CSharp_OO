using Exercice_Monopolis.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Monopolis.Models
{
    internal class Jeu
    {
        #region Variables membre et propriétés
        private List<Joueur> _joueurs;
        private List<CasePropriete> _plateau;

        public Joueur[] Joueurs
        {
            get { return _joueurs?.ToArray(); }
            /*private set
            {
                _joueurs = new List<Joueur>(value);
            }*/
        }

        public CasePropriete[] Plateau
        {
            get
            {
                return _plateau.ToArray();
            }
        }
        #endregion

        #region Indexeurs
        public CasePropriete this[int numeroCase]
        {
            get
            {
                numeroCase %= _plateau.Count;
                return _plateau[numeroCase];
            }
        }

        /// <summary>
        /// Recherche d'un pion dans la liste de joueurs
        /// </summary>
        /// <param name="pion">le pion que l'on recherche</param>
        /// <returns>Si un joueur existe avec le pion retourne le si non retourne null</returns>
        public Joueur? this[Pions pion]
        {
            get
            {
                foreach (Joueur j in _joueurs)
                {
                    if (j.Pion == pion) return j;
                }
                return null;
            }
        }

        #endregion

        //public Jeu(List<CasePropriete> casesPlateau)
        //{
        //    _joueurs = new List<Joueur>();
        //    _plateau = casesPlateau;

        //}

        public Jeu(CasePropriete[] casesPlateau)
        {
            _joueurs = new List<Joueur>();
            _plateau = new List<CasePropriete>(casesPlateau);
            // initialisation d'une liste à partir d'un array methode raccourcie
            //_plateau = [.. casesPlateau];
        }

        public void AjouterJoueur(string nom, Pions pion)
        {
            foreach (Joueur j in _joueurs)
            {
                if (j.Pion == pion)
                {
                    Console.WriteLine($"Le pion {pion} est déjà pris.");
                    return;
                }
            }
            _joueurs.Add(new Joueur(nom, pion));
        }

    }
}
