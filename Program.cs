using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpaceConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            #region INSTANCIATIONS
            // Instanciation de la liste des planetes
            List<Planet> planets = new List<Planet>();

            // Instanciations des Types de planetes
            PlaOceanique planeteOceanique = new PlaOceanique();
            PlaTemperee planeteTemperee = new PlaTemperee();
            PlaAride planeteAride = new PlaAride();
            PlaVolcanique planeteVolcanique = new PlaVolcanique();
            PlaArctique planeteArctique = new PlaArctique();
            
            // Instanciation des Exploitations
            ExAgricole exploitAgricole = new ExAgricole();
            ExScientifique exploitScientifique = new ExScientifique();
            ExMiniere exploitMiniere = new ExMiniere();
            ExIndustrielle exploitIndustrielle = new ExIndustrielle();
            ExMegapole exploitMegapole = new ExMegapole();
            #endregion

            try
            {
                // Instance unique de Random pr eviter les redondances dans la randomization
                Random rnd = new Random();

                // INPUT
                Console.WriteLine("Entrez le nombre de planètes à générer :");
                nb = Convert.ToInt32(Console.ReadLine());

                #region CREATION (RANDOM) DES PLANETES
                // Création (RANDOM) des Planetes 
                // on peut certainement mieux faire en ré-utilisant ListExploitation(), mais au moins ça marche
                for (int i = 0; i < nb; i++)
                {
                    int p = rnd.Next(1, 6); // Random Planet Type
                    object pla = new object();
                    object exp = new object();
                    switch (p)
                    {
                    case 1:
                        int e = rnd.Next(1, 3); // Random Exploitation Type OCEANIQUE
                        switch (e)
                        {
                            case 1:
                                planeteOceanique.setExploitation(exploitAgricole);
                                break;
                            case 2:
                                planeteOceanique.setExploitation(exploitScientifique);
                                break;
                        }
                        break;
                    case 2:
                        e = rnd.Next(1, 6); // Random Exploitation Type TEMPEREE
                        switch (e)
                        {
                            case 1:
                                planeteTemperee.setExploitation(exploitAgricole);
                                break;
                            case 2:
                                planeteTemperee.setExploitation(exploitScientifique);
                                break;
                            case 3:
                                planeteTemperee.setExploitation(exploitMiniere);
                                break;
                            case 4:
                                planeteTemperee.setExploitation(exploitIndustrielle);
                                break;
                            case 5:
                                planeteTemperee.setExploitation(exploitMegapole);
                                break;
                        }
                        break;
                    case 3:
                        e = rnd.Next(1, 4); // Random Exploitation Type ARIDE
                        switch (e)
                        {
                            case 1:
                                planeteAride.setExploitation(exploitMiniere);
                                break;
                            case 2:
                                planeteAride.setExploitation(exploitIndustrielle);
                                break;
                            case 3:
                                planeteAride.setExploitation(exploitMegapole);
                                break;
                        }
                        break;
                    case 4:
                        e = rnd.Next(1, 4); // Random Exploitation Type VOLCANIQUE
                        switch (e)
                        {
                            case 1:
                                planeteVolcanique.setExploitation(exploitScientifique);
                                break;
                            case 2:
                                planeteVolcanique.setExploitation(exploitMiniere);
                                break;
                            case 3:
                                planeteVolcanique.setExploitation(exploitIndustrielle);
                                break;
                        }
                        break;
                    case 5:
                        e = rnd.Next(1, 3); // Random Exploitation Type ARCTIQUE
                        switch (e)
                        {
                            case 1:
                                planeteArctique.setExploitation(exploitScientifique);
                                break;
                            case 2:
                                planeteArctique.setExploitation(exploitMiniere);
                                break;                                
                        }
                        break;
                    }
                    // Sleep 10ms pour tenter d'eviter les redondances dans la randomisation ?
                    // System.Threading.Thread.Sleep(10);
                    // Console.Write(".");      // Pour visualiser le delai 'Sleep'
                }
                #endregion

                Console.ReadKey();

                #region ---LEGACY---
                /* ---LEGACY---
                planetoceanique.setExploitation(exploitagricole);            
                planetoceanique.setExploitation(exploitscientifique);

                planetetemperee.setExploitation(exploitagricole);
                planetetemperee.setExploitation(exploitscientifique);
                planetetemperee.setExploitation(exploitminiere);
                planetetemperee.setExploitation(exploitindustrielle);
                planetetemperee.setExploitation(exploitmegapole);
                */
                #endregion
            }
            catch (BadExploitException ex)
            {
                Console.WriteLine(ex.MyMessage);
                Console.ReadKey();
            }
        }


        public static int nb = new int();   // Utilisé dans AbstractPlanet pour déterminer quelle planete est la derniere crée

        // Liste déclarée ici a cause des tentatives de recup la liste ici, voir methode void setExploitation()
        public static List<Planet> planets = new List<Planet>();

    }
}
