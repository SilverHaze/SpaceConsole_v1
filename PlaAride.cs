using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class PlaAride : AbstractPlanet
    {
        public PlaAride()
        {
            this.ListExploitation = new Type[] { typeof(ExMiniere), typeof(ExIndustrielle), typeof(ExMegapole) };
        }
    }
}
