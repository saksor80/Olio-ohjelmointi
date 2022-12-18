using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antikvariaatti
{
    class Ihminen
    {
        protected String nimi;
        public Ihminen()
        { }

        public Ihminen(String n)
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
