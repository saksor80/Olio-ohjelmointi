using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linnut
{
    class Muuttolintu: Lintu
    {
        private String suomeenMuuttoKuukausi;
        private Muuttomaa maa;
        private Pesa p;

        public Muuttolintu()
        { }
        public Muuttolintu(String n, String s)
        {
            nimi = n;
            suomeenMuuttoKuukausi = s;
        }
        public void laitaKK(String s)
        {
            suomeenMuuttoKuukausi = s;
        }
        public void laitaKaikkitiedot(String n, String s)
        {
            nimi = n;
            suomeenMuuttoKuukausi = s;
        }
        public void laitaMuuttomaa(Muuttomaa m)
        {
            maa = m;
        }
        public void laitaPesa(Pesa pp)
        {
            p = pp;
        }
        public String palautaKK()
        {
            return suomeenMuuttoKuukausi;
        }
        public String palautaKuvaNimi()
        {
            String KuvaNimi = nimi + ".jpg";
            return KuvaNimi;
        }
        public String palautaAani()
        {
            String aani = nimi + ".wav";
            return aani;
        }
        public String tulostakaikkiTiedot()
        {
            String info = "Nimi on " + nimi + " ja muuttaa Suomeen ";
            info = info + suomeenMuuttoKuukausi + " ja muuttomaa on " + maa.palautaMaa() + ". ";
            info = info + p.tulostaTiedot();
            return info;
        }
    }
}
