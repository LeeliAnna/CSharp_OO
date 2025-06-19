using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_InterfaceExceptionDeleguer.Models
{
    internal class Renard : Personnage
    {
        public delegate void DCrie(string lecri); //Prototype de la fonction qui pourrait être appelée par le délégué
        // evenement qui va emettre ce qui est contenu dans le déléguer
        public event DCrie ECrie;
        public Renard(string nom):base(nom)
        {
            
        }

        private void Glapit()
        {
            ECrie("AAAAAAAAAAAAAAAhJIpJIpYOOOOOOOOOOOOOOOO");
        }

        internal void VoitLaPoule()
        {
            Glapit();
        }
    }
}
