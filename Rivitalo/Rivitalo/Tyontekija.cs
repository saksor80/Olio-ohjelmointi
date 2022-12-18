using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivitalo
{
    class Tyontekija: Ihminen
    {
        private String firmakoodi;

        public Tyontekija()
        { }
        public Tyontekija(String n, String k, int s)
        {
            nimi = n;
            firmakoodi = k;
            syntymavuosi = s;
        }
        public void laitaKaikkitiedot(String n, String k, int s)
        {
            nimi = n;
            firmakoodi = k;
            syntymavuosi= s;
        }
        public void laitaFirmakoodi(String k)
        {
            firmakoodi = k;
        }
        public String palautaFirmakoodi()
        {
            return firmakoodi;
        }
    }
}
