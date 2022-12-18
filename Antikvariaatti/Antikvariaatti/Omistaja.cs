using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antikvariaatti
{
    class Omistaja: Ihminen
    {
        private String puhnro;

        public Omistaja()
        { }
        public Omistaja(String n, String e)
        {
            nimi = n;
            puhnro = e;
        }
        public void laitaPuhnro(String e)
        {
            puhnro = e;
        }
        public String palautaPuhnro()
        {
            return puhnro;
        }
    }
}
