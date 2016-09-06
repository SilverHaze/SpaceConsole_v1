using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class Ressource : IRessource
    {
        
        private object resName;
        private object resDescription;
        private object resPMoy;
        private object resPMin;
        private object resPMax;

        public Ressource(object na, object d, object m, object n, object x)
        {
            this.resName = na;
            this.resDescription = d;
            this.resPMoy = m;
            this.resPMin = n;
            this.resPMax = x;
        }
        public object ResName
        {
            get { return this.resName; }
            set { this.resName = value; }
        }
        public object ResDescription
        {
            get { return this.resDescription; }
            set { this.resDescription = value; }
        }
        public object ResPMoy
        {
            get { return this.resPMoy; }
            set { this.resPMoy = value; }
        }
        public object ResPMin
        {
            get { return this.resPMin; }
            set { this.resPMin = value; }
        }
        public object ResPMax
        {
            get { return this.resPMax; }
            set { this.resPMax = value; }
        }
        
    }

    /* Instanciation des Ressources
    Ressource silicium = new Ressource("Silicium", "Matière première utilisée pour la fabrication de tout Circuit Intégré", 15, 10, 25);
    Ressource metaux = new Ressource("Metaux", "Aliages métaliques principalement utilisés pour la construction de structures", 25, 20, 35);
    Ressource metauxprec = new Ressource("Metaux Précieux", "Métaux souvent utilisés dans la fabrication de Composants", 100, 9, 10);
    Ressource polymeres = new Ressource("Polymères", "Aliages de matériaux synthétiques isolants utlisés dans la construction de structures", 20, 15, 30);
    Ressource composants = new Ressource("Composants", "Nécéssaires à la frabrication et l'entretient de systemes informatisés ou robotisés", 50, 40, 60);
    Ressource cells = new Ressource("Cellules d'Energie", "Utiles partout et tout le temps, elles alimentent la plupart des machines", 40, 35, 50);
    Ressource mineraux = new Ressource("Minéraux", "Utilisés dans certains Composants ou dans certaines Industries Lourdes", 80, 70, 95);
    Ressource cereales = new Ressource("Céréales", "La base alimentaire de toute la galaxie", 15, 10, 20);
    Ressource viande = new Ressource("Viande", "Complément alimentaire de ceux qui peuvent se le permettre", 30, 20, 45);
    Ressource spiritieux = new Ressource("Spiritueux", "Illégaux dans de nombreux systemes, ces substances sont pourtant très prisés", 130, 90, 180);
    */

    /*
    class Silicium : Ressource
    {

    }
    class Metaux : Ressource
    {
    }
    class MetauxPrec : Ressource
    {
    }
    class Polymeres : Ressource
    {
    }
    class Composants : Ressource
    {
    }
    class Cells : Ressource
    {
    }
    class Mineraux : Ressource
    {
    }
    class Cereales : Ressource
    {
    }
    class Viande : Ressource
    {
    }
    class Spiritieux : Ressource
    {
    }
    */
}
