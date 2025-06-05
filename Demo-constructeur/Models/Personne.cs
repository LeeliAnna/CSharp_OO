using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_constructeur.Models
{
    internal class Personne
    {
        private string _nom;

        public string Nom
        {
            //lis la valeur et la retourne pour l'utilisation
            get
            {
                // Méthode pour couper une chaine de caractère : substring(caractere de depart, longueur a prendre en compte) si longueur non précisée il prendra tout en compte.
                return _nom.Substring(0, 1).ToUpper() + _nom.Substring(1).ToLower();
            }
            //sauvegarde la valeur et on y effectue les test
            private set
            {
                value = value.Trim();
                if (value.Length > 2)
                {
                    _nom = value;
                }
            }
        }

        //private string _prenom;

        //public string Prenom
        //{
        //    //lis la valeur
        //    get 
        //    {
        //        return _prenom;
        //    }
        //    //sauvegarde la valeur
        //    set 
        //    {
        //        _prenom = value;
        //    }
        //}
        public string Prenom { get; set; }


        public string NomComplet
        {
            get
            {
                return $"{Prenom} {Nom}";
            }
        }

        private DateOnly _dateNaissance;

        public DateOnly DateNaissance
        {
            set
            {
                _dateNaissance = value;
            }
        }

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - _dateNaissance.Year;
                if (DateTime.Now.Month < _dateNaissance.Month)
                {
                    age--;
                }
                return age;
            }
        }

        public Personne()
        {
            Nom = "Smith";
            Prenom = "John";
            DateNaissance = new DateOnly(1974, 01, 19);
        }

        public Personne(string paramNom) : this()
        {
            Nom = paramNom;
        }

        public Personne(string paramNom, string paramPrenom): this()
        {
            //Nom = paramNom;
            Prenom = paramPrenom;
        }
        public Personne(string paramNom, string paramPrenom, DateOnly paramNaiss) 
        {
            Nom = paramNom;
            Prenom = paramPrenom;
            DateNaissance = paramNaiss;
        }


        public void JoyeuxAnniversaire()
        {
            if (DateTime.Now.Day == _dateNaissance.Day && DateTime.Now.Month == _dateNaissance.Month)
            {
                Console.WriteLine("Joyeux Anniversaire 🥳");
            }
            else
            {
                Console.WriteLine("Joyeux Non-Anniversaire 🥳");
            }
        }

        
    }
}
