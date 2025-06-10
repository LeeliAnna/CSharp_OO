using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Indexeur.Models
{
    internal class Personnage
    {
        public string Nom { get; set; }
        public int Taille { get; set; }
        //public List<Equipement> Equipements { get; set; }
        private Dictionary<String, Equipement> _equipements;

        public Equipement? this[string key]
        {
            get
            {
                if (_equipements.ContainsKey(key)) { return _equipements[key]; }
                else { return null };
            }
            set
            {
                if (_equipements is null)
                {
                    _equipements = new Dictionary<String, Equipement>();
                }
                _equipements[key] = value;
            }
        }
    }
}
