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
            // Liste des planetes
            List<Planet> planets = new List<Planet>();

            // Types de planetes
            PlaOceanique planeteOceanique = new PlaOceanique();
            PlaTemperee planeteTemperee = new PlaTemperee();
            PlaAride planeteAride = new PlaAride();
            PlaVolcanique planeteVolcanique = new PlaVolcanique();
            PlaArctique planeteArctique = new PlaArctique();
            
            // Exploitations
            ExAgricole exploitAgricole = new ExAgricole();
            ExScientifique exploitScientifique = new ExScientifique();
            ExMiniere exploitMiniere = new ExMiniere();
            ExIndustrielle exploitIndustrielle = new ExIndustrielle();
            ExMegapole exploitMegapole = new ExMegapole();

            // Vaisseaux
            Ship shipPelican = new Ship("Pelican I", "Pelican", 250, 15000, 60, "Faible Capacité", "Economique, fiable et très répandu, son faible tonnage montre cependant rapidement ses limites.");
            Ship shipOrca = new Ship("Orca I", "Orca", 700, 40000, 160, "Capacité Moyenne", "Accessible, ce vaisseau puissant est un compromis idéal, du fait de sa capacité respectable et de son coût modéré.");
            Ship shipMammoth = new Ship("Mammoth I", "Mammoth", 1500, 90000, 300, "Grande Capacité", "Hors de prix pour la plupart des commercants, permet de stocker jusqu'au meilleur moment, tout en saisissant les occasions de passage.");
            Ship shipTitan = new Ship("Titan I", "Titan", 3500, 210000, 750, "Très Grande Capacité", "Le rève ultime de tout commercant qui se respecte. Ce cargo au tonnage exceptionnel est aussi un signe exterrieur de richesse certain.");

            // Ressources
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

            #region MENU
            menu1:
            // MENU (1 = Planetes, 2 = Ressources, 3 = Vaisseaux)
            Console.WriteLine("Actions disponibles :\n1 - Générer les planètes \n2 - Consulter les ressources\n3 - Consulter les vaisseaux \nQue faire ?");
            try
            {
                var inputMenu = Convert.ToInt32(Console.ReadLine());
                switch (inputMenu)
                {
                    case 1:
                        goto inputPlanets;
                    case 2:
                        goto inputRes;
                    case 3:
                        goto inputShip;
                    default:
                        Console.WriteLine("Erreur: Saisie non valide\n");
                        goto menu1;
                }
            }
            catch (Exception ex)
            {
                var exMsg = ex;
                Console.WriteLine("Erreur: Saisie non valide\n");
                goto menu1;
            }
            #endregion

            #region SHIP
            inputShip:
            string[] ShipNames = { "Advenna Avis", "Argonaut", "Blue 6", "Shang 9", "Going Merry", "Thousand Sunny", "Thriller Bark", "Oro Jackson", "Moby Dick", "JDS Mirai", "JDF Ishin", "Over the Rainbow", "Pascal Magi", "Ghost Ship", "Super 99", "Tempest Junior", "Tuatha de Danaan", "Yashiromaru", "St. Aphrodite", "Blue", "Yamato", "FortreOne", "Illustria", "Asuka II", "Naked Sun", "Harekaze", "Aurora", "The Black Freighter", "Borneo Prince", "Cithara", "Cutlass", "Eagle's Shadow", "Grossadler", "Hawksub", "Karaboudjan", "Salty Space Mare", "Ramona", "Space Queen", "The Gertrude", "Sirius", "Unicorn", "Viper", "Vulkan", "Abraham Lincoln", "Academic Vladislav Volkov", "Acheron", "Aeolus", "African Queen", "Amindra", "Andes", "Angelina", "Antonia Graza", "Aquanaut 3", "Arabella", "Aspen", "Avenger", "Batavia Queen", "Bedford", "Belafonte", "Belinda", "Benthic Explorer", "Black Hawk", "Black Pearl", "Black Swan", "Brandenburg", "Britannic", "Caine", "Caledonia", "Charleston", "Chester", "Davies", "Devonshire", "Chiku Shan", "Claridon", "CompaRose", "Copperfin", "Crescent Star", "Deep Quest", "Defiant", "Disco Volante", "Dragonfish", "Dulcibella", "Echo", "Edinburgh Trader", "Elizabeth Dane", "Empress", "Endeavour", "Ergenstrasse", "Essess", "Flying Dutchman", "The Flying Wasp", "Geronimo", "Ghost", "Glencairn", "Gloria N", "Goliath", "Hahnchen Maru", "Hai Peng", "Happy Wanderer", "Haynes", "The Henrietta", "Immer Essen", "The Inferno", "Interceptor", "Intrepid", "Jenny", "Calypso", "Lansing", "Liparus", "Love Nest", "Lydia", "Mary Deare", "Minnow Johnson", "Montana", "Morning Star", "Nathan Ross", "Nautilus", "Nereid", "Ning-Po", "Oakland", "Orca", "Patna", "Pequod", "Poseidon", "PrinceIrene", "Q Boat", "Proteus", "Rachel", "Reaper", "Red Dragon", "Red Witch", "Red October", "Reluctant", "U-571", "Rights-of-Man", "Rob Roy", "San Pablo", "Saltash Castle", "Saracen", "Sawfish", "Scotia", "Space Cliff", "Space Star", "Space Tiger", "Space Witch", "SSNR Spaceview", "Shag at Space", "Sherwood", "Solent", "IJN Shinaru", "St. Georges", "Starfish", "Stingray", "Sutherland", "Thunderfish", "Tigerfish", "Tiger Shark", "Torrin", "Turtle", "Ulysses", "Valhalla", "Venture", "Venus", "Viperess", "Victoria", "The Wanderer", "Wonkatania", "Yellow Submariner" };

            Console.WriteLine("\nActions disponibles :\n1 - Classe 'Pelican' \n2 - Classe 'Orca' \n3 - Classe 'Mammoth' \n4 - Classe 'Titan' \n \nSélectionnez une fiche de vaisseau à consulter:");
            Ship selectedShip = null;
            try
            {
                var inputShip = Convert.ToInt32(Console.ReadLine());
                switch (inputShip)
                {
                    case 1:
                        selectedShip = shipPelican;
                        break;
                    case 2:
                        selectedShip = shipOrca;
                        break;
                    case 3:
                        selectedShip = shipMammoth;
                        break;
                    case 4:
                        selectedShip = shipTitan;
                        break;
                    default:
                        Console.WriteLine("Erreur: Saisie non valide\n");
                        goto menu1;
                }
                Console.WriteLine(ReadShip(selectedShip) + "\n");
                Console.ReadKey();
                goto menu1;
            }
            catch (Exception ex)
            {
                var exMsg = ex;
                Console.WriteLine("Erreur: Saisie non valide\n");
                goto menu1;
            }
            #endregion

            #region CONSULTATION RESOURCES
        // INPUT
            inputRes:
            Console.WriteLine("\nRessources disponibles :\n1 - Silicium\n2 - Metaux\n3 - Metaux Precieux\n4 - Polymères\n5 - Composants\n6 - Cellules d'Energie\n7 - Minéraux\n8 - Céréales\n9 - Viande\n10 - Spiritueux \n \nSélectionnez une ressource à consulter:");
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
                Console.ReadKey();
                goto menu1;
            }
            catch (Exception ex)
            {
                var exMsg = ex;
                Console.WriteLine("Erreur: Saisie non valide\n");
                goto inputRes;
            }
            #endregion

            inputPlanets:
            try
            {
                // Instance unique de Random pr eviter les redondances dans la randomization
                Random rnd = new Random();

                // Array Noms de Planètes [FR] (env. 580)
                //string[] StarNameStr = { "Acamar", "Achernar", "Achird", "Acrab", "Acrux", "Acubens", "Adara", "Adhaféra", "Adhil", "Adib", "Adkhaféra", "Agéna", "Aïn", "Ak", "Akhamar", "Akhénar", "Akrab", "Akruks", "Akubens", "Aladfar", "Alamak", "Alanf", "Alanz", "Alaraf", "Alaraph", "Alashfar", "Alathfar", "Alatik", "Albaldah", "Albali", "Albiréo", "Alcaïd", "Alchiba", "Alcor", "Alcyone", "Aldanab", "Aldébaran", "Aldhaféra", "Aldhanab", "Aldhiba", "Aldhibah", "Aldhiha", "Aldib", "Aldzhabkhakh", "Alfakka", "Alfaret", "Alfarg", "Alfard", "Alfecca", "Alférats", "Alfirk", "Alga", "Algébar", "Algédi", "Algéiba", "Algénib", "Algénubi", "Algiéba", "Algiedi", "Algol", "Algomeyla", "Algomeysa", "Algorab", "Alhajoth", "Al", "Hammam", "Alhéna", "Aliath", "Alifa", "Alioth", "Alkab", "Alkaïd", "Alkalb", "Alkalurops", "Alkand", "Alkaphrah", "Alkes", "Alkhajot", "Alkhéna", "Alkurhah", "Almaach", "Almaak", "Mankib", "Almizar", "Almucédie", "Alnaïr", "Alnath", "Alnitam", "Alnitak", "Alniyat", "Alphakka", "Alphart", "Alphératz", "Alphirk", "Alraï", "Rakis", "Alrisha", "Alruccaba", "Alsabik", "Alsafi", "Alsahm", "Alnakah", "Alschaïrn", "Alshaïn", "Alsciaukat", "Sharataïn", "Alshat", "Alshémali", "Alsuhail", "Altarf", "Altaïr", "Altaïs", "Tarf", "Alterf", "Altsione", "Aludra", "Alula", "Alwaïd", "Alwazor", "Alya", "Alzirr", "Ancha", "Angetenar", "Ankaa", "Anser", "Antarès", "Antécanis", "Anwar", "Apollo", "Arcturus", "Arich", "Aridif", "Arietis", "Arkab", "Arktur", "Arm", "Arneb", "Arraï", "Arrakis", "Arrioph", "Ascella", "Aschéré", "Asellus", "Asgard", "Ashtaroth", "Askéla", "Asmidiske", "Aspidiske", "Astérion", "Astérope", "Astsella", "Asuia", "Ataïr", "Athafi", "Atik", "Atlas", "Atria", "Auva", "Avior", "Azelfafage", "Azha", "Azimech", "Azmidiske", "Baham", "Bakham", "Baten", "Bécrux", "Beemin", "Beïd", "Békruks", "Bellatrix", "Benetnasch", "Bételgeuze", "Biham", "Boteïn", "Brachium", "Cajam", "Calx", "Canicula", "Canopus", "Capella", "Caph", "Caput", "Castor", "Cébalraï", "Céginus", "Celaeno", "Céline", "Cexing", "Chaph", "Chara", "Cheleb", "Chertan", "Chort", "Clava", "Cor", "Coxa", "Cujam", "Cursa", "Cymbae", "Cygnus", "Cynosura", "Dabih", "Dana", "Déneb", "Dénébola", "Dhalim", "Dheneb", "Diadème", "Difda", "Dikhabda", "Diphda", "Dirakh", "Dschubba", "Dsiban", "Dubhé", "Duhr", "Dzhanakh", "Dzhubba", "Dziban", "Edasich", "Eldsib", "Ehlekctra", "Ehlgomajza", "Ehlnatkh", "Ehlyakrab", "Ehrakis", "Ehtamin", "Elacrab", "Eldsich", "Électre", "Electra", "Elgébar", "ElGhoul", "Elgomaïsa", "Elkeïd", "Elkhereb", "Elkhiffa", "ElKoprah", "ElMélik", "Elmuthalleth", "ElNasl", "Elnath", "ElRakis", "ElRischa", "Eltanin", "Énif", "Épi", "Érakis", "Erraï", "Errakis", "Étanin", "Fakt", "Falx", "Ferkad", "Fidis", "Fom", "Fomalhaut", "Foramen", "Fum", "Furud", "Gacrux", "Gainsar", "Gallina", "Gamal", "Gemma", "Genam", "Giauzar", "Giénah", "Gienakh", "Gildun", "Girtab", "Gnedi", "Gnosia", "Gomeïsa", "Gorgona", "Grafias", "Granatovaya", "Grassias", "Gredi", "Grenat", "Grumium", "Hadar", "Haedus", "Hamal", "Hamul", "Haris", "Hassaleh", "Hatysa", "Heka", "Hemal", "Hercule", "Heze", "Hoedus", "Homam", "Hyadum", "Hydor", "Icalurus", "Iclarkrau", "Inkalunis", "Isida", "Isis", "Izar", "Jabbah", "Jed", "Jildun", "Juza", "Kabalraï", "Kabeleced", "Kaf", "Kaffa", "Kaffalidma", "Kaitain", "Kajam", "Kakkab", "Kalb", "KalbalAkrab", "Kalbelaphard", "Kantajn", "Kanopus", "Kapella", "Kastor", "Kastra", "Kaus", "Keïd", "KelbAlraï", "Kerb", "Khadar", "Khamal", "Khan", "Khara", "Kheka", "Kheze", "Khomam", "Khort", "Kied", "Kiffa", "Kinosura", "Kitalpha", "Kocab", "KorKaroli", "Korneferos", "Krats", "Kraz", "Ksora", "KullatNunu", "Kuma", "Kurhah", "Kursa", "Labr", "LaSuperba", "Lesath", "LucidaCymbae", "Maasym", "Mabsuthat", "Maïa", "Majya", "Manubrij", "Marchab", "Marfak", "Marfic", "Marj", "Markab", "Markeb", "Marrha", "Marsik", "Masym", "Matar", "Meboula", "Media", "Megrez", "Meïssa", "Mekbuda", "Melucta", "Menchib", "Menkab", "Menkalina", "Menkar", "Menkent", "Menkib", "Mentar", "Merak", "Merez", "Merga", "Merkab", "Mérope", "Mesartim", "Metallah", "Mezartim", "Miaplacidus", "Mifrid", "Mimosa", "Minchir", "Minelauva", "Minkar", "Mintaka", "Mira", "Miram", "Mirak", "Mirakh", "Mirfak", "Mirza", "Mismar", "Misam", "Mizar", "Monkar", "Motallakh", "Muhlifaïn", "Muliphen", "Muphrid", "Murfach", "Murzim", "Muscida", "NairalSaïf", "NaïralSaïf", "NaïralZaurak", "Naos", "Nash", "Nashira", "Nat", "Navigatoria", "Nekkar", "Nibal", "Nicolaus", "Nihal", "Nod", "Nunki", "Nusakan", "Nushaba", "Oculus", "Okda", "Okul", "Os", "Palilicium", "Paon", "Parilicium", "Pelag", "Perse", "Phacd", "Phad", "Phakt", "Pherkad", "Phurud", "Pikok", "PishPai", "Pléione", "Polaris", "Polis", "Pollux", "Polyarnaya", "Porrima", "Praecipua", "Praepes", "Praesepe", "Prezepe", "PrimaGiedi", "Printseps", "Procyon", "Propus", "Protrigetrix", "Proxima", "Propus", "Protsion", "Pulcherrima", "Rana", "Rasaben", "Rasalas", "Rasalgethi", "Rasalhague", "Raselased", "Rasehlgul", "Rashammel", "Rastaban", "Rasthaoum", "Reda", "Regor", "Régulus", "Resha", "Rigel", "Rotanen", "Rukba", "Rutilicus", "Saad", "Sabik", "Saclateni", "Sadachbia", "Sadalbari", "Sadalmelik", "Sadalsud", "Sadatoni", "Sadr", "Sadira", "Sadlamulk", "Saïdak", "Salm", "Sargas", "Sarin", "Sartan", "Scalovin", "Sceptrum", "Scheddi", "Scutulum", "Seat", "Seginus", "SerdtseCarla", "Sertan", "Shaf", "Sham", "Sharatan", "Shaula", "Shedir", "Shératan", "Shiliak", "Sinistra", "Sirius", "Situla", "Skat", "Soleil", "Spica", "Stérope", "Sualocin", "Sualotsin", "Subra", "Suhaïl", "Suhel", "Sulafat", "Svalocin", "Syrma", "Tabit", "Tajgeta", "Talita", "Tania", "Tarazed", "Tarf", "Taygète", "Tegmen", "Tejat", "Terebellum", "Teyat", "Thabit", "Theemin", "Thuban", "Toliman", "Torcularis", "Tramontana", "Tsebalraj", "Tsih", "Tsolma", "Tuban", "Tureis", "Tyl", "Unuk", "Urkab", "Vasat", "Véga", "Venabulum", "Venatici", "Vendémiatrix", "Venator", "Vespertilio", "Vezad", "Vezen", "Vildiur", "Wasat", "Wazn", "Wéga", "Wezen", "Yed", "Yildun", "Yilduz", "Zaniah", "Zarijan", "Zaurak", "Zavijah", "Zibal", "Zosma", "ZubenElakrab", "Zubenelgenubi", "Zubenesch", "Zubenhakraki", "Zubra" };
                // Array Planets Names [EN] (env. 360)
                string[] StarNameStr = { "Acamar", "Achernar", "Achird", "Acrab", "Acrux", "Acubens", "Adhafera", "Adhara", "Adhil", "Ain", "Aladfar", "Alamak", "Alathfar", "Alaraph", "Albaldah", "Albali", "Albireo", "Alchiba", "Alcor", "Alcyone", "Aldebaran", "Alderamin", "Aldhafera", "Aldhanab", "Aldhibain", "Aldib", "Al Fawaris", "Alfecca Meridiana", "Alfirk", "Al Giedi", "Algedi", "Algenib", "Algieba", "Algol", "Algorab", "Alhajoth", "Alhena", "Alioth", "Alkaid", "Al Kurud", "Al Kalb al Rai", "Alkalurops", "Al Kaphrah", "Alkes", "Alkurah", "Almach", "Al Minliar al Asad", "Alnair", "Alnasl", "Alnilam", "Alnitak", "Alniyat", "Al Niyat", "Alphard", "Alphecca", "Alpheratz", "Alrai", "Alrami", "Alrescha", "Alsafi", "Alsciaukat", "Alshain", "Alshat", "Altair", "Altais", "Altarf", "Alterf", "Al Thalimain", "Al Thalimain", "Aludra", "Alula Australis", "Alula Borealis", "Alwaid", "Alya", "Alzir", "Ancha", "Angetenar", "Ankaa", "Antares", "Arcturus", "Arich", "Arkab", "Armus", "Arneb", "Arrakis", "Ascella", "Asellus Australis", "Asellus Borealis", "Asellus Primus", "Asellus Secundus", "Asellus Tertius", "Askella", "Aspidiske", "Asterion", "Asterope", "Atik", "Atlas", "Atria", "Auva", "Avior", "Azaleh", "Azelfafage", "Azha", "Azmidiske", "Baham", "Baten Kaitos", "Beid", "Bellatrix", "Benetnasch", "Betelgeuse", "Betria", "Biham", "Botein", "Brachium", "Bunda", "Canopus", "Capella", "Caph", "Castor", "Cebalrai", "Celaeno", "Cervantes", "Chalawan", "Chara", "Chara", "Cheleb", "Chertan", "Chort", "Chow", "Copernicus", "Cor Caroli", "Cursa", "Dabih", "Decrux", "Deneb", "Deneb Algedi", "Deneb Dulfim", "Deneb el Okab", "Deneb Kaitos", "Deneb Kaitos Schemali", "Denebola", "Dheneb", "Diadem", "Diphda", "Dnoces", "Dschubba", "Dubhe", "Duhr", "Edasich", "Electra", "Elmuthalleth", "Elnath", "Eltanin", "Enif", "Errai", "Fafnir", "Fomalhaut", "Fum al Samakah", "Furud", "Gacrux", "Garnet Star", "Gatria", "Gemma", "Gianfar", "Giedi", "Gienah Gurab", "Gienah", "Girtab", "Gomeisa", "Gorgonea Tertia", "Grumium", "Hadar", "Haedus", "Haldus", "Hamal", "Hassaleh", "Helvetios", "Head of Hydrus", "Heka", "Heze", "Hoedus", "Homam", "Hyadum", "Hydrobius", "Intercrus", "Izar", "Jabbah", "Kabdhilinan", "Kaffaljidhma", "Kajam", "Kastra", "Kaus Australis", "Kaus Borealis", "Kaus Media", "Keid", "Kitalpha", "Kochab", "Kornephoros", "Kraz", "Kullat Nunu", "Kuma", "La Superba", "Lesath", "Libertas", "Lucida Anseris", "Maasym", "Mahasim", "Maia", "Marfark", "Marfik", "Markab", "Matar", "Mebsuta", "Media", "Megrez", "Meissa", "Mekbuda", "Menchib", "Menkab", "Menkalinan", "Menkar", "Menkent", "Menkib", "Merak", "Merga", "Merope", "Mesarthim", "Miaplacidus", "Mimosa", "Minchir", "Minelava", "Minkar", "Mintaka", "Mira", "Mirach", "Miram", "Mirfak", "Mirzam", "Misam", "Mizar", "Mothallah", "Muliphein", "Muphrid", "Murzim", "Muscida", "Muscida", "Musica", "Nair Al Saif", "Naos", "Nash", "Nashira", "Navi", "Nekkar", "Nembus", "Nihal", "Nunki", "Nusakan", "Ogma", "Okul", "Peacock", "Phact", "Phecda", "Pherkad", "Pherkard", "Pleione", "Polaris", "Polaris Australis", "Pollux", "Porrima", "Praecipua", "Procyon", "Propus", "Proxima Centauri", "Ran", "Rana", "Rasalgethi", "Rasalhague", "Ras Elased Australis", "Rasalas", "Rastaban", "Ras Thaoum", "Regor", "Regulus", "Rigel", "Rigil Kentaurus", "Rijl al Awwa", "Rotanev", "Ruchba", "Ruchbah", "Rukbat", "Sabik", "Sadachbia", "Sadalbari", "Sadalmelik", "Sadalsuud", "Sadatoni", "Sadr", "Saiph", "Salm", "Sargas", "Sarin", "Sarir", "Sceptrum", "Scheat", "Scheddi", "Schedar", "Segin", "Seginus", "Sham", "Shaula", "Sheliak", "Sheratan", "Sinistra", "Sirius  Dog Star", "Situla", "Skat", "Spica", "Sterope", "Sualocin", "Subra", "Suhail", "Sulafat", "Syrma", "Tabit", "Talitha Australis", "Talitha", "Tania Australis", "Tania Borealis", "Tarazed", "Taygeta", "Tegmen", "Terebellum", "Tejat Posterior", "Tejat Prior", "Thabit", "Theemin", "Thuban", "Tien Kwan", "Titawin", "Tonatiuh", "Torcularis Septentrionalis", "Tureis", "Tyl", "Unukalhai", "Vega", "Veritate", "Vindemiatrix", "Wasat", "Wazn", "Wezen", "Yed Prior", "Yed Posterior", "Yildun", "Zaniah", "Zaurak", "Zavijava", "Zosma", "Zuben-el-Akrab", "Zuben-el-Akribi", "Zubenelgenubi", "Zubeneschamali" };
                
                // Convert Array to List (pour pouvoir l'editer et eviter les doublons)
                var StarList = new List<string>(StarNameStr);

                // INPUT
                inputPla:
                Console.WriteLine("\nEntrez le nombre de planètes à générer (max: " + StarList.Count + ") :");
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
                goto menu1;
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

        // Affiche les informations d'un Vaisseau
        private static string ReadShip(Ship s)
        {
            return "Classe '" + s.ShipClass + "' (" + s.ShipPrice + " credits) \nCargo : " + s.ShipCargoStr + " (" + s.ShipCargo + ") \nMaintenance : " + s.ShipMaintCost + " credits / Tour \n" + s.ShipDescr + "\n";
        }

        public static string rndStar;           // Utilisé plus haut pour déterminer un nom de planete
        public static int nbPla = new int();    // Utilisé dans AbstractPlanet pour déterminer quelle planete est la derniere crée

        // Liste déclarée ici a cause des tentatives de recup la liste ici, voir methode void setExploitation()
        public static List<Planet> planets = new List<Planet>();


    }
}
