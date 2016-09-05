using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class PlaArctique : AbstractPlanet // héritage de IPlanete
    {
        public PlaArctique()
        {
            this.ListExploitation = new Type[] { typeof(ExScientifique), typeof(ExMiniere), typeof(ExIndustrielle)};
        }
    }
}
