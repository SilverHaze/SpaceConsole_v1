using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class PlaTemperee : AbstractPlanet
    {
        public PlaTemperee()
        {
            this.ListExploitation = new Type[] { typeof(ExAgricole), typeof(ExScientifique), typeof(ExMiniere), typeof(ExIndustrielle), typeof(ExMegapole) };
        }
    }
}
