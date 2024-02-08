using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formkontrollsystem
{
    internal class Trekant : Form
    {
        private double Base;
        private double Høyde;
        private string Måletype;

        public Trekant(double basenr, double høyde, string måletype, string navn, string farge)
        {
            Base = basenr;
            Høyde = høyde;
            Måletype = måletype;
            Navn = navn;
            Farge = farge;
        }

        internal override double BeregnAreal()
        {
            double SkriveUt = 0.5 * Høyde * Base;
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
