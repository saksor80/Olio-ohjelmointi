using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antikvariaatti
{
    class Kirja
    {
        private String nimi;
        private int sivut;
        private Kirjoittaja kirjoittaja;

        public Kirja()
        { }
        public Kirja(String n, int s, Kirjoittaja k)
        {
            nimi = n;
            sivut = s;
            kirjoittaja = k;
        }
        public void laitaKaikkitiedot(String n, int s, Kirjoittaja k)
        {
            nimi = n;
            sivut = s;
            kirjoittaja = k;
        }
        public void laitaNimi(String n)
        {
            nimi = n;
        }
        public String palautaNimi()
        {
            return nimi;
        }
        public void laitaSivut(int s)
        {
            sivut = s;
        }
        public int palautaSivut()
        {
            return sivut;
        }
        public void laitaKirjoittaja(Kirjoittaja k)
        {
            kirjoittaja = k;
        }
        public String palautaKirjoittaja()
        {
            return kirjoittaja.palautaKirjoittaja() + "\n" + "(" + kirjoittaja.palautaEmail() + ")";
        }
        //public String palautaKirjatiedot()
        //{
        //    //kesken
        //    String info = kirjoittaja.palautaKirjoittaja();
        //    
        //    return info;
        //}
    }
}
