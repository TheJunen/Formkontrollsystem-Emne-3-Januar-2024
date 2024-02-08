using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formkontrollsystem
{
    internal class Rektangel : Form
    {
        private double Lengde;
        private double Bredde;
        private string Måletype;

        public Rektangel(double lengde, double bredde, string måletype, string navn, string farge)
        {
            Lengde = lengde;
            Bredde = bredde;
            Måletype = måletype;
            Navn = navn;
            Farge = farge;
        }
        internal override double BeregnAreal()
        {
            double SkriveUt = Lengde * Bredde;
            return SkriveUt;
        }

        internal override string PrintUtAreal()
        {
            double SkriveUt = BeregnAreal();
            return SkriveUt + " " + Måletype + " " + Navn + " " + Farge;
        }
    }
}
