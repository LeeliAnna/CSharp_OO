using Demo_InterfaceExceptionDeleguer.Enums;
using Demo_InterfaceExceptionDeleguer.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_InterfaceExceptionDeleguer.Interfaces
{
    /// <summary>
    /// Definir les actions et propriétés obligatoires d'une poule
    /// </summary>
    internal interface IPersonnage
    {
        // Propriete
        string Nom { get; }


        // Méthodes
        Position Avancer(int distance, DIRECTION direction);
    }
}
