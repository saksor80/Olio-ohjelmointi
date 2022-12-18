using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antikvariaatti
{
    class Kirjoittaja: Ihminen
    {
        private String email;

        public Kirjoittaja()
        { }
        public Kirjoittaja(String n, String e)
        {
            nimi = n;
            email = e;
        }
        public void laitaEmail(String e)
        {
            email = e;
        }
        public String palautaEmail()
        {
            return email;
        }
        public String palautaKirjoittaja()
        {
            return nimi;
        }
    }
}
