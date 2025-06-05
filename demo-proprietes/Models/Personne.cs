using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_proprietes.Models
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
                return _nom.Substring(0,1).ToUpper() + _nom.Substring(1).ToLower();
            }
            //sauvegarde la valeur et on y effectue les test
            set
            {
                value = value.Trim();
                if (value.Length > 2) 
                {
                    _nom = value;
                }
            }
        }

        private string _prenom;

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
