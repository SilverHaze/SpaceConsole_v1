using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    abstract class AbstractShip : IShipClass
    {
        //private object shipID;
        //private object shipName;      
        private object shipClass;       // Type de vaisseau
        private object shipCargo;       // Capacité
        private object shipPrice;       // Cout du Vaisseau à l'achat
        private object shipMaintCost;   // Cout de Maintenance / Tour
        private object shipCargoStr;    // Description du Tonnage
        private object shipDescr;       // Description du Vaisseau

        // public Ship(int i, string n, string cl, int ca, int p, int mc, string cs, string d)
        public void SetShipClass(string cl, int ca, int p, int mc, string cs, string d)
        {
            //this.shipID = i;
            //this.shipName = n;
            this.shipClass = cl;
            this.shipCargo = ca;
            this.shipPrice = p;
            this.shipMaintCost = mc;
            this.ShipCargoStr = cs;
            this.shipDescr = d;
        }
        /*
        public object ShipID
        {
            get { return this.shipID; }
            set { this.shipID = value; }
        }
        public object ShipName
        {
            get { return this.shipName; }
            set { this.shipName = value; }
        }
        */
        public object ShipClass
        {
            get { return this.shipClass; }
            set { this.shipClass = value; }
        }
        public object ShipCargo
        {
            get { return this.shipCargo; }
            set { this.shipCargo = value; }
        }
        public object ShipPrice
        {
            get { return this.shipPrice; }
            set { this.shipPrice = value; }
        }
        public object ShipMaintCost
        {
            get { return this.shipMaintCost; }
            set { this.shipMaintCost = value; }
        }
        public object ShipCargoStr
        {
            get { return this.shipCargoStr; }
            set { this.shipCargoStr = value; }
        }
        public object ShipDescr
        {
            get { return this.shipDescr; }
            set { this.shipDescr = value; }
        }
    }
}
