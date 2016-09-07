using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class ShipPelican : AbstractShip
    {
        public ShipPelican()
        {
            this.SetShipClass("Pelican", 250, 15000, 60, "Faible Capacité", "Economique, fiable et très répandu, son faible tonnage montre cependant rapidement ses limites.");
        }
        
    }
}
