using Demo_InterfaceExceptionDeleguer.Enums;
using Demo_InterfaceExceptionDeleguer.Exceptions;
using Demo_InterfaceExceptionDeleguer.Interfaces;
using Demo_InterfaceExceptionDeleguer.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Demo_InterfaceExceptionDeleguer.Models
{
    internal class Poule : Personnage
    {
        public Poule(string nom): base(nom)
        {
            
        }

        public void FuitPauvrePoule(string leCri)
        {
            Console.WriteLine($"Le renard dit {leCri}.");
            Avancer(2, DIRECTION.Arriere);
        }
    }
}
