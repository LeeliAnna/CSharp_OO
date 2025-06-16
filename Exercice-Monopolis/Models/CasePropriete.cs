using Exercice_Monopolis.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Monopolis.Models
{
    internal class CasePropriete : Case
    {

        #region Variables et propriétés
        //private string? _nom;
        private Couleurs _couleurs;
        private int _prix;
        private bool _estHypotequee;
        private Joueur? _proprietaire;

        //public string? Nom
        //{
        //    get { return _nom; }
        //    private set { _nom = value; }
        //}

        public Couleurs Couleurs
        {
            get { return _couleurs; }
            private set { _couleurs = value; }
        }

        public int Prix
        {
            get
            {
                return _prix;
            }

            private set
            {
                if (value > 0) 
                { 
                    _prix = value;
                }
            }
        }

        public bool EstHypotequee
        {
            get
            {
                return _estHypotequee;
            }

            private set
            {
                _estHypotequee = value;
            }
        }

        internal Joueur? Proprietaire
        {
            get
            {
                return _proprietaire;
            }

            private set
            {
                _proprietaire = value;
            }
        } 
        #endregion

        //public CasePropriete() { }

        public CasePropriete(string paramNom, Couleurs paramCouleur, int paramPrix) : base(paramNom)
        {
            //Nom = paramNom;
            Couleurs = paramCouleur;
            Prix = paramPrix;
            EstHypotequee = false;
            Proprietaire = null;
        }

        private void Acheter(Joueur acheteur)
        {
            int soldeFinal = acheteur.Solde - Prix;
            if (acheteur is not null && acheteur.Solde >= Prix && Proprietaire is null)
            {
                acheteur.Payer(Prix);
                if(soldeFinal == acheteur.Solde)
                {
                    Proprietaire = acheteur;
                }
            }

        }

        private void Sejourner(Joueur visiteur)
        {
            visiteur.Payer((Prix / 4));
        }

        public override void Activer(Joueur visiteur)
        {
            if (Proprietaire is null) 
            {
                Acheter(visiteur);
            }else
            {
                Sejourner(visiteur);
            }
        }
    }
}
