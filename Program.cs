using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpaceConsole
{
    class Program
    {
        // ENUMS

        // enum ResEnum { silicium, metaux, metauxprec, polymeres, composants, cells, mineraux, cereales, viande, spiritieux };
        
        // 57
        //enum StarNames { Baham, Bakham, Baten, Bécrux, Beemin, Beïd, Békruks, Bellatrix, Benetnasch, Bételgeuze, Biham, Boteïn, Brachium, Cajam, Calx, Canicula, Canopus, Capella, Caph, Caput, Castor, Cébalraï, Céginus, Celaeno, Céline, Cexing, Chaph, Chara, Cheleb, Chertan, Chort, Clava, Cor, Coxa, Cujam, Cursa, Cymbae, Cygnus, Cynosura, Dabih, Dana, Déneb, Dénébola, Dhalim, Dheneb, Diadème, Difda, Dikhabda, Diphda, Dirakh, Dschubba, Dsiban, Dubhé, Duhr, Dzhanakh, Dzhubba, Dziban };
            

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

            #region CONSULTATION RESOURCES
        // INPUT
            inputRes:
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
                        Console.WriteLine("Erreur: Saisie non valide\n");
                        goto inputRes;
                }
                Console.WriteLine(ReadResObj(ResObj) + "\n");
            }
            catch (Exception ex)
            {
                var exMsg = ex;
                Console.WriteLine("Erreur: Saisie non valide\n");
                goto inputRes;
            }
            #endregion

            try
            {
                // Instance unique de Random pr eviter les redondances dans la randomization
                Random rnd = new Random();

                // Array [Noms de Planètes]
                string[] StarNameStr = { "Acamar", "Achernar", "Achird", "Acrab", "Acrux", "Acubens", "Adara", "Adhaféra", "Adhara", "Adhil", "Adib", "Adkhaféra", "Agéna", "Aïn", "Ak", "Akhamar", "Akhénar", "Akrab", "Akruks", "Akubens", "Aladfar", "Alamak", "Alanf", "Alanz", "Alaraf", "Alaraph", "Alashfar", "Alathfar", "Alatik", "Albaldah", "Albali", "Albiréo", "Alcaïd", "Alchiba", "Alcor", "Alcyone", "Aldanab", "Aldébaran", "Aldhaféra", "Aldhanab", "Aldhiba", "Aldhibah", "Aldhiha", "Aldib", "Aldzhabkhakh", "Alfakka", "Alfaret", "Alfarg", "Alfard", "Alfecca", "Alférats", "Alfirk", "Alga", "Algébar", "Algédi", "Algéiba", "Algénib", "Algénubi", "Algiéba", "Algiedi", "Algol", "Algomeyla", "Algomeysa", "Algorab", "Alhajoth", "Al", "Hammam", "Alhéna", "Aliath", "Alifa", "Alioth", "Alkab", "Alkaïd", "Alkalb", "Alkalurops", "Alkand", "Alkaphrah", "Alkes", "Alkhajot", "Alkhéna", "Alkurhah", "Almaach", "Almaak", "Mankib", "Almizar", "Almucédie", "Alnaïr", "Alnath", "Alnitam", "Alnitak", "Alniyat", "Alphakka", "Alphart", "Alphératz", "Alphirk", "Alraï", "Rakis", "Alrisha", "Alruccaba", "Alsabik", "Alsafi", "Alsahm", "Alnakah", "Alschaïrn", "Alshaïn", "Alsciaukat", "Sharataïn", "Alshat", "Alshémali", "Alsuhail", "Altarf", "Altaïr", "Altaïs", "Tarf", "Alterf", "Altsione", "Aludra", "Alula", "Alwaïd", "Alwazor", "Alya", "Alzirr", "Ancha", "Angetenar", "Ankaa", "Anser", "Antarès", "Antécanis", "Anwar", "Apollo", "Arcturus", "Arich", "Aridif", "Arietis", "Arkab", "Arktur", "Arm", "Arneb", "Arraï", "Arrakis", "Arrioph", "Ascella", "Aschéré", "Asellus", "Asgard", "Ashtaroth", "Askéla", "Asmidiske", "Aspidiske", "Astérion", "Astérope", "Astsella", "Asuia", "Ataïr", "Athafi", "Atik", "Atlas", "Atria", "Auva", "Avior", "Azelfafage", "Azha", "Azimech", "Azmidiske", "Baham", "Bakham", "Baten", "Bécrux", "Beemin", "Beïd", "Békruks", "Bellatrix", "Benetnasch", "Bételgeuze", "Biham", "Boteïn", "Brachium", "Cajam", "Calx", "Canicula", "Canopus", "Capella", "Caph", "Caput", "Castor", "Cébalraï", "Céginus", "Celaeno", "Céline", "Cexing", "Chaph", "Chara", "Cheleb", "Chertan", "Chort", "Clava", "Cor", "Coxa", "Cujam", "Cursa", "Cymbae", "Cygnus", "Cynosura", "Dabih", "Dana", "Déneb", "Dénébola", "Dhalim", "Dheneb", "Diadème", "Difda", "Dikhabda", "Diphda", "Dirakh", "Dschubba", "Dsiban", "Dubhé", "Duhr", "Dzhanakh", "Dzhubba", "Dziban", "Edasich", "Eldsib", "Ehlekctra", "Ehlgomajza", "Ehlnatkh", "Ehlyakrab", "Ehrakis", "Ehtamin", "Elacrab", "Eldsich", "Électre", "Electra", "Elgébar", "ElGhoul", "Elgomaïsa", "Elkeïd", "Elkhereb", "Elkhiffa", "ElKoprah", "ElMélik", "Elmuthalleth", "ElNasl", "Elnath", "ElRakis", "ElRischa", "Eltanin", "Énif", "Épi", "Érakis", "Erraï", "Errakis", "Étanin", "Fakt", "Falx", "Ferkad", "Fidis", "Fom", "Fomalhaut", "Foramen", "Fum", "Furud", "Gacrux", "Gainsar", "Gallina", "Gamal", "Gemma", "Genam", "Giauzar", "Giénah", "Gienakh", "Gildun", "Girtab", "Gnedi", "Gnosia", "Gomeïsa", "Gorgona", "Grafias", "Granatovaya", "Grassias", "Gredi", "Grenat", "Grumium", "Hadar", "Haedus", "Hamal", "Hamul", "Haris", "Hassaleh", "Hatysa", "Heka", "Hemal", "Hercule", "Heze", "Hoedus", "Homam", "Hyadum", "Hydor", "Icalurus", "Iclarkrau", "Inkalunis", "Isida", "Isis", "Izar", "Jabbah", "Jed", "Jildun", "Juza", "Kabalraï", "Kabeleced", "Kaf", "Kaffa", "Kaffalidma", "Kaitain", "Kajam", "Kakkab", "Kalb", "KalbalAkrab", "Kalbelaphard", "Kantajn", "Kanopus", "Kapella", "Kastor", "Kastra", "Kaus", "Keïd", "KelbAlraï", "Kerb", "Khadar", "Khamal", "Khan", "Khara", "Kheka", "Kheze", "Khomam", "Khort", "Kied", "Kiffa", "Kinosura", "Kitalpha", "Kocab", "KorKaroli", "Korneferos", "Krats", "Kraz", "Ksora", "KullatNunu", "Kuma", "Kurhah", "Kursa", "Labr", "LaSuperba", "Lesath", "LucidaCymbae", "Maasym", "Mabsuthat", "Maïa", "Majya", "Manubrij", "Marchab", "Marfak", "Marfic", "Marj", "Markab", "Markeb", "Marrha", "Marsik", "Masym", "Matar", "Meboula", "Media", "Megrez", "Meïssa", "Mekbuda", "Melucta", "Menchib", "Menkab", "Menkalina", "Menkar", "Menkent", "Menkib", "Mentar", "Merak", "Merez", "Merga", "Merkab", "Mérope", "Mesartim", "Metallah", "Mezartim", "Miaplacidus", "Mifrid", "Mimosa", "Minchir", "Minelauva", "Minkar", "Mintaka", "Mira", "Miram", "Mirak", "Mirakh", "Mirfak", "Mirza", "Mismar", "Misam", "Mizar", "Monkar", "Motallakh", "Muhlifaïn", "Muliphen", "Muphrid", "Murfach", "Murzim", "Muscida", "NairalSaïf", "NaïralSaïf", "NaïralZaurak", "Naos", "Nash", "Nashira", "Nat", "Navigatoria", "Nekkar", "Nibal", "Nicolaus", "Nihal", "Nod", "Nunki", "Nusakan", "Nushaba", "Oculus", "Okda", "Okul", "Os", "Palilicium", "Paon", "Parilicium", "Pelag", "Perse", "Phacd", "Phad", "Phakt", "Pherkad", "Phurud", "Pikok", "PishPai", "Pléione", "Polaris", "Polis", "Pollux", "Polyarnaya", "Porrima", "Praecipua", "Praepes", "Praesepe", "Prezepe", "PrimaGiedi", "Printseps", "Procyon", "Propus", "Protrigetrix", "Proxima", "Propus", "Protsion", "Pulcherrima", "Rana", "Rasaben", "Rasalas", "Rasalgethi", "Rasalhague", "Raselased", "Rasehlgul", "Rashammel", "Rastaban", "Rasthaoum", "Reda", "Regor", "Régulus", "Resha", "Rigel", "Rotanen", "Rukba", "Rutilicus", "Saad", "Sabik", "Saclateni", "Sadachbia", "Sadalbari", "Sadalmelik", "Sadalsud", "Sadatoni", "Sadr", "Sadira", "Sadlamulk", "Saïdak", "Salm", "Sargas", "Sarin", "Sartan", "Scalovin", "Sceptrum", "Scheddi", "Scutulum", "Seat", "Seginus", "SerdtseCarla", "Sertan", "Shaf", "Sham", "Sharatan", "Shaula", "Shedir", "Shératan", "Shiliak", "Sinistra", "Sirius", "Situla", "Skat", "Soleil", "Spica", "Stérope", "Sualocin", "Sualotsin", "Subra", "Suhaïl", "Suhel", "Sulafat", "Svalocin", "Syrma", "Tabit", "Tajgeta", "Talita", "Tania", "Tarazed", "Tarf", "Taygète", "Tegmen", "Tejat", "Terebellum", "Teyat", "Thabit", "Theemin", "Thuban", "Toliman", "Torcularis", "Tramontana", "Tsebalraj", "Tsih", "Tsolma", "Tuban", "Tureis", "Tyl", "Unuk", "Urkab", "Vasat", "Véga", "Venabulum", "Venatici", "Vendémiatrix", "Venator", "Vespertilio", "Vezad", "Vezen", "Vildiur", "Wasat", "Wazn", "Wéga", "Wezen", "Yed", "Yildun", "Yilduz", "Zaniah", "Zarijan", "Zaurak", "Zavijah", "Zibal", "Zosma", "ZubenElakrab", "Zubenelgenubi", "Zubenesch", "Zubenhakraki", "Zubra" };
                // Convert Array to List (pour pouvoir l'editer et eviter les doublons)
                var StarList = new List<string>(StarNameStr);

                // INPUT
                inputPla:
                Console.WriteLine("Entrez le nombre de planètes à générer (max: " + StarList.Count + ") :");
                nbPla = Convert.ToInt32(Console.ReadLine());
                if (nbPla > StarList.Count || nbPla < 0) 
                {
                    Console.WriteLine("Veuillez entrer un nombre compris entre 0 et " + StarList.Count + "\n");
                    goto inputPla;
                }

                #region CREATION (RANDOM) DES PLANETES
                // Création (RANDOM) des Planetes 
                // on peut mieux faire, par ex. en ré-utilisant ListExploitation(), mais au moins ça marche

                for (int i = 0; i < nbPla; i++)
                {
                    // Pick a RANDOM Planet Name
                    int r = rnd.Next(StarList.Count);
                    rndStar = (string)StarList[r];
                    //string[] testArray = { "1", "2", "3" };
                    
                    StarList.Remove(rndStar);
                    StarNameStr = StarList.ToArray();

                    
                    int p = rnd.Next(1, 6);     // Random Planet Type
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
                        e = rnd.Next(1, 6);     // Random Exploitation Type TEMPEREE
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
                        e = rnd.Next(1, 4);     // Random Exploitation Type ARIDE
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
                        e = rnd.Next(1, 4);     // Random Exploitation Type VOLCANIQUE
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
                        e = rnd.Next(1, 3);     // Random Exploitation Type ARCTIQUE
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

        // Affiche les informations d'une Ressource
        private static string ReadResObj(Ressource r)
        {
            return r.ResName.ToString() + " (Prix Moyen: " + r.ResPMoy + " - Min: " + r.ResPMin + " - Max: " + r.ResPMax + ")\n" + r.ResDescription.ToString();
        }



        public static string rndStar;           // Utilisé plus haut pour déterminer un nom de planete
        public static int nbPla = new int();    // Utilisé dans AbstractPlanet pour déterminer quelle planete est la derniere crée

        // Liste déclarée ici a cause des tentatives de recup la liste ici, voir methode void setExploitation()
        public static List<Planet> planets = new List<Planet>();


    }
}
