using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class PlaOceanique : AbstractPlanet // héritage de IPlanete
    {
        public PlaOceanique()
        {
            this.ListExploitation = new Type[]{typeof(ExAgricole), typeof(ExScientifique)};
        }
    }
}
