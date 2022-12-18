using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linnut
{
    class Lintu
    {
        protected String nimi;
        public Lintu()
        { }

        public Lintu(String n)
        { 
            nimi = n; 
        }
        public void laitaNimi(String n)
        {
            nimi = n;
        }

        public String palautaNimi()
        {
            return nimi;
        }
    }
}
