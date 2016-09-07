using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class ShipMammoth : AbstractShip
    {
        public ShipMammoth()
        {
            this.SetShipClass("Orca", 700, 40000, 160, "Capacité Moyenne", "Accessible, ce vaisseau puissant est un compromis idéal, du fait de sa capacité respectable et de son coût modéré.");
        }
    }
}
