using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    abstract class AbstractPlanet : IPlanete
    {
        #region INIT
        IExploitation exploit;
        public IExploitation getExploitation()
        {
            return exploit; // recupere la variable d'Exploitation attribuée
        }

        public Type[] ListExploitation { get; set; }    

        // portion de texte a retirer pr la lisibilité, lors de la conversion Object -> ToString()
        String remPla = "SpaceConsole.Pla";
        String remExp = "SpaceConsole.Ex";
        #endregion

        #region METHODES [ setExploitation(), IsGoodExploitation(), CreatePlanet() ]
        public void setExploitation(IExploitation aexploit)
        {
            if (IsGoodExploitation(aexploit))
            {
                exploit = aexploit;
                CreatePlanet(aexploit);     // Créer une instance d'Object 'Planet'
            }
            else
            {
                // exception
                String p = Convert.ToString(this.GetType());
                String e = Convert.ToString(aexploit.GetType());
                throw new BadExploitException(String.Format("Planete {0} ne peut avoir le type d'exploitation {1}", p.Replace(remPla, string.Empty), e.Replace(remExp, string.Empty)));
            }
        }

        private bool IsGoodExploitation(IExploitation aexploit)
        {
            bool res = false;
            Type atype = aexploit.GetType();            
            foreach (Type t in ListExploitation)
            {
                res = true;
                break;
            }
            return res;
        }

        private object CreatePlanet(IExploitation aexploit)
        {
            /* LISTE les Planetes lors de la création de CHACUNE (en utilisant le type attribué)
            object pl = this.GetType();
            object ex = aexploit.GetType();
            String p = Convert.ToString(pl).Replace(remPla, string.Empty);
            String e = Convert.ToString(ex).Replace(remExp, string.Empty);
            Console.WriteLine(String.Format("\nNouvelle planète {0} ({1})", p, e));
            */

            // Instanciation de l'objet 'Planet'
            Planet planet = new Planet(Program.rndStar, this.GetType(), aexploit.GetType());            
            
            // Ajout de cette instance de l'objet 'Planet' à la liste des planètes
            Program.planets.Add(planet);

            // LISTE les planètes, lors de la création de la DERNIERE (en utilisant les propriétés des instances de l'OBJET 'Planet')
            if (Program.nbPla == Program.planets.Count())
            {
                Console.WriteLine("\n");
                var planetsArray = Program.planets.ToArray();
                foreach (var item in planetsArray)
                {                
                    String p = Convert.ToString(item.PlaType).Replace("SpaceConsole.Pla", string.Empty);
                    String e = Convert.ToString(item.PlaExploit).Replace("SpaceConsole.Ex", string.Empty);
                    Console.WriteLine(item.PlaName + " - " + p + " " + e);                    
                }
                Console.WriteLine("\n--> " + planetsArray.Count() + " planètes générées.");
            }
            return Program.planets;     // tentative de recup la liste dans Program, mais echouée car cette methode est void
        }
        #endregion
    }
}