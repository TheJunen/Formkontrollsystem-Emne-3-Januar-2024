using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formkontrollsystem
{
    internal class Sirkel : Form
    {
        private double Radius;
        private string Måletype;

        public Sirkel (double radius, string måletype, string navn, string farge)
        {
            Radius = radius * radius;
            Måletype = måletype;
            Navn = navn;
            Farge = farge;
        }

        internal override double BeregnAreal()
        {
            double Pi = 3.14159;
            double SkriveUt = Pi * Radius;
            //Console.WriteLine(SkriveUt + " " + Måletype + " " + Navn + " " + Farge);
            return SkriveUt;
        }

        internal override string PrintUtAreal()
        {
            double SkriveUt = BeregnAreal();
            return SkriveUt + " " + Måletype + " " + Navn + " " + Farge;
        }
    }
}
