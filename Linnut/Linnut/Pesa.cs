using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linnut
{
    class Pesa
    {
        private String sijainti;
        private Raaka_aine r1, r2, r3;

        public void laitaSij(String m)
        {
            sijainti = m;
        }
        public String palautaSij()
        {
            return sijainti;
        }
        public void laitaRaakaAineet(Raaka_aine rr1, Raaka_aine rr2, Raaka_aine rr3)
        {
            r1 = rr1; r2 = rr2; r3 = rr3;
        }
        public String tulostaTiedot()
        {
            String info = "Pesän sijainti on " + sijainti + " ja pesän raaka-aineet ovat: ";
                   info = info + r1.tulostaTiedot() + r2.tulostaTiedot() + r3.tulostaTiedot();
            return info;
        }
    }
}
