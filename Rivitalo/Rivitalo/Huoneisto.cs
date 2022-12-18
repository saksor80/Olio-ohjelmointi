using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivitalo
{
    class Huoneisto
    {
        private int hmaara;
        private int kpala;
        private Omistaja omistaja;

        public Huoneisto()
        { }
        public Huoneisto(int h, int k)
        {
            hmaara = h;
            kpala = k;
        }
        public void laitaHmaara(int h)
        {
            hmaara = h;
        }
        public int palautaHmaara()
        {
            return hmaara;
        }
        public void laitaKpala(int k)
        {
            kpala = k;
        }
        public int palautaKpala()
        {
            return kpala;
        }
        public int palautaSyntymavuosi()
        {
            return kpala;
        }
        public void laitaOmistaja(Omistaja oo)
        {
            omistaja = oo;
        }
    }
}
