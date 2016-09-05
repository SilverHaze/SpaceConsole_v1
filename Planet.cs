using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    // Classe de l'Objet 'Planet' (certainement laborieux, mais ça marche)
    // Contient des parametres pas encore utilisés (ID et Nom de planete).
    public class Planet
    {
        //private object plaID;
        //private object plaName;
        private object plaType;
        private object plaExploit;

        //public Planet(int i, string n, object p, object e)
        public Planet(object p, object e)
        {
            //this.plaID = i;
            //this.plaName = n;
            this.plaType = p;
            this.plaExploit = e;
        }
        /*
        public object PlaID
        {
            get { return this.plaID; }
            set { this.plaID = value; }
        }
        public object PlaName
        {
            get { return this.plaName; }
            set { this.plaName = value; }
        }
        */
        public object PlaType
        {
            get { return this.plaType; }
            set { this.plaType = value; }
        }
        public object PlaExploit
        {
            get { return this.plaExploit; }
            set { this.plaExploit = value; }
        }
    }
}
