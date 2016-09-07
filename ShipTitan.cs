using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class ShipTitan : AbstractShip
    {
        public ShipTitan()
        {
            this.SetShipClass("Titan", 3500, 210000, 750, "Très Grande Capacité", "Le rève ultime de tout commercant qui se respecte. Ce cargo au tonnage exceptionnel est aussi un signe exterrieur de richesse certain.");
        }
    }
}
