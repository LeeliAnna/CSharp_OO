using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Démo_enumeration.Enums;

namespace Démo_enumeration.Models
{
    internal class Trafficlight
    {
        //public string[] colors;
        //public int currentColor;
        public TrafficLightColors currentColor;


        public void ChangeColor()
        {
            if (currentColor is TrafficLightColors.vert)
            {
                currentColor = TrafficLightColors.orange;
            }
            else if (currentColor is TrafficLightColors.orange)
            {
                currentColor = TrafficLightColors.rouge;
            }
            else
            {
                currentColor = TrafficLightColors.vert;
            }
        }
    }
}
