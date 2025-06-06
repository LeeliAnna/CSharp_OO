﻿using Exercice_Monopolis.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Monopolis.Models
{
    internal class CasePropriete
    {

        private string _nom;
        private Couleurs _couleurs;
        private int _prix;
        private bool _estHypotequee;
        private Joueur _proprietaire;

        public string Nom 
        {
            get { return _nom; }
            private set { _nom = value; }
        }

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
                _prix = value;
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

        internal Joueur Proprietaire
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

        public CasePropriete() { }

        public CasePropriete(string paramNom, Couleurs paramCouleur, int paramPrix)
        {
            Nom = paramNom;
            Couleurs = paramCouleur;
            Prix = paramPrix;
            EstHypotequee = false;
            Proprietaire = null;
        }

        public void Acheter(Joueur acheteur)
        {
            if (acheteur.Solde < Prix)
            {
                Proprietaire = acheteur;
                acheteur.Acheter(Prix);
            }

        }


    }
}
