using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KółkoIKrzyżyk
{
    internal class wszeczasyPunkt
    {
        public wszeczasyPunkt(int kolko, int remis, int krzyzyk)
        {
            this.kolko = kolko;
            this.remis = remis;
            this.krzyzyk = krzyzyk;
        }

        public int kolko { get; set; }
        public int remis { get; set; }
        public int krzyzyk { get; set; }
    }
}
