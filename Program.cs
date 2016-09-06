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

            // Instanciation des Ressources
            /*
            Silicium silicium = new Silicium();
            Metaux metaux = new Metaux();
            MetauxPrec metauxprec = new MetauxPrec();
            Polymeres polymeres = new Polymeres();
            Composants composants = new Composants();
            Cells cells = new Cells();
            Mineraux mineraux = new Mineraux();
            Cereales cereales = new Cereales();
            Viande viande = new Viande();
            Spiritieux spiritieux = new Spiritieux();
            */

            Ressource silicium = new Ressource("Silicium", "Matière première utilisée pour la fabrication de tout Circuit Intégré", 15, 10, 25);
            Ressource metaux = new Ressource("Metaux", "Aliages métaliques principalement utilisés pour la construction de structures", 25, 20, 35);
            Ressource metauxprec = new Ressource("Metaux Précieux", "Métaux souvent utilisés dans la fabrication de Composants", 100, 9, 10);
            Ressource polymeres = new Ressource("Polymères", "Aliages de matériaux synthétiques isolants utlisés dans la construction de structures", 20, 15, 30);
            Ressource composants = new Ressource("Composants", "Nécéssaires à la frabrication et l'entretient de systèmes informatisés ou robotisés", 50, 40, 60);
            Ressource cells = new Ressource("Cellules d'Energie", "Utiles partout et tout le temps, elles alimentent la plupart des machines", 40, 35, 50);
            Ressource mineraux = new Ressource("Minéraux", "Utilisés dans l'Industrie, notement dans la fabrications de Cellules d'Energie", 80, 70, 95);
            Ressource cereales = new Ressource("Céréales", "La base alimentaire de toute la galaxie", 15, 10, 20);
            Ressource viande = new Ressource("Viande", "Complément alimentaire de ceux qui peuvent se le permettre", 30, 20, 45);
            Ressource spiritieux = new Ressource("Spiritueux", "Illégaux dans de nombreux systemes, ces substances sont pourtant très prisées", 130, 90, 180);
            
            #endregion

            // INPUT
            input1:
            Console.WriteLine("Ressources disponibles :\n1 - Silicium\n2 - Metaux\n3 - Metaux Precieux\n4 - Polymères\n5 - Composants\n6 - Cellules d'Energie\n7 - Minéraux\n8 - Céréales\n9 - Viande\n10 - Spiritueux \nQuelle ressource consulter ?");
            try
            {
                var res = Convert.ToInt32(Console.ReadLine());
                Ressource ResObj = null;
                switch (res)
                {
                    case 1:
                        ResObj = silicium;
                        break;
                    case 2:
                        ResObj = metaux;
                        break;
                    case 3:
                        ResObj = metauxprec;
                        break;
                    case 4:
                        ResObj = polymeres;
                        break;
                    case 5:
                        ResObj = composants;
                        break;
                    case 6:
                        ResObj = cells;
                        break;
                    case 7:
                        ResObj = mineraux;
                        break;
                    case 8:
                        ResObj = cereales;
                        break;
                    case 9:
                        ResObj = viande;
                        break;
                    case 10:
                        ResObj = spiritieux;
                        break;
                    default:
                        Console.WriteLine("Argument non valide\n");
                        goto input1;
                }
                Console.WriteLine(ReadResObj(ResObj) + "\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Argument non valide\n");
                goto input1;
            }


            try
            {
                // Instance unique de Random pr eviter les redondances dans la randomization
                Random rnd = new Random();

                // INPUT
                Console.WriteLine("Entrez le nombre de planètes à générer :");
                nbPla = Convert.ToInt32(Console.ReadLine());
                

                #region CREATION (RANDOM) DES PLANETES
                // Création (RANDOM) des Planetes 
                // on peut certainement mieux faire en ré-utilisant ListExploitation(), mais au moins ça marche
                for (int i = 0; i < nbPla; i++)
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

        private static string ReadResObj(Ressource r)
        {
            return r.ResName.ToString() + " (Prix Moyen: " + r.ResPMoy + " - Min: " + r.ResPMin + " - Max: " + r.ResPMax + ")\n" + r.ResDescription.ToString();
        }



        public static int nbPla = new int();   // Utilisé dans AbstractPlanet pour déterminer quelle planete est la derniere crée

        // Liste déclarée ici a cause des tentatives de recup la liste ici, voir methode void setExploitation()
        public static List<Planet> planets = new List<Planet>();

    }
}
