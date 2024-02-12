using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formkontrollsystem
{
    abstract class Form
    {   
        protected string Navn;
        internal string Farge;

        internal abstract double BeregnAreal();

        internal abstract string PrintUtAreal();

        //internal abstract double 
    }
}
