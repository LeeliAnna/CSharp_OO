using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_InterfaceExceptionDeleguer.Exceptions
{
    public class DirectionException : Exception
    {
        //Permet de custom notre type d'exception en les regroupants dans un seul endroit
        public DirectionException() : base("La direction n'est pas permise") { }
    }

    public class RenardException : Exception
    {
        public RenardException() : base("Le renard à mangé la poule!"){ }
    }
}
