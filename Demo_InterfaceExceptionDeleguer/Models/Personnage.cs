using Demo_InterfaceExceptionDeleguer.Enums;
using Demo_InterfaceExceptionDeleguer.Exceptions;
using Demo_InterfaceExceptionDeleguer.Interfaces;
using Demo_InterfaceExceptionDeleguer.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_InterfaceExceptionDeleguer.Models
{
    public abstract class Personnage : IPersonnage
    {
        private Position _emplacement;

        /// <summary>
        /// Readonly => Uniquement possible d'instancier la variable par le constructeur
        /// </summary>
        private readonly string _nom;


        public string Nom
        {
            get
            {
                return _nom;
            }
        }


        /// <summary>
        /// Constructeur permettande de nommer la poule
        /// </summary>
        /// <param name="nomDeLaPoule">Devin??</param>
        public Personnage(string nomDuPerso)
        {
            _nom = nomDuPerso;
            _emplacement.X = 0;
            _emplacement.Y = 0;
        }


        /// <summary>
        /// Fonction permettant de faire avancer la poule sur le plateau
        /// </summary>
        /// <param name="distance">Nombre de cases de déplacement</param>
        /// <param name="direction">Direction du déplacement</param>
        /// <returns>L'emplacement de la poule sur le plateau sous la forme d'une Position</returns>
        /// <exception cref="DirectionException">si l'exception n'est pas correcte</exception>
        public Position Avancer(int distance, DIRECTION direction)
        {
            switch (direction)
            {
                case DIRECTION.Avant:
                    _emplacement.X += distance;
                    break;
                case DIRECTION.Arriere:
                    _emplacement.X -= distance;
                    break;
                case DIRECTION.Haut:
                    _emplacement.Y -= distance;
                    break;
                case DIRECTION.Bas:
                    _emplacement.Y += distance;
                    break;
                default:
                    // c'est une erreur
                    throw new DirectionException();
            }
            return _emplacement;
        }
    }
}
