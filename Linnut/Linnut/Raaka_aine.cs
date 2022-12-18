using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linnut
{
    class Raaka_aine
    {
        private String aineenNimi;

        public void laitaTiedot(String m)
        {
            aineenNimi = m;
        }
        public String tulostaTiedot()
        {
            String x = "Raaka-aine on " + aineenNimi + ". ";
            return x;
        }
    }
}
