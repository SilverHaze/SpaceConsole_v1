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
}
