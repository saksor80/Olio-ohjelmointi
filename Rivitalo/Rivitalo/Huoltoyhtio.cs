using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivitalo
{
    class Huoltoyhtio
    {
        private String nimi;
        private String LYtunnus;
        public List<Tyontekija> rekisteri = new List<Tyontekija>();

        public Huoltoyhtio()
        { }

        public Huoltoyhtio(String n, String l)
        {
            nimi = n;
            LYtunnus = l;
        }
        public void laitaNimi(String n)
        {
            nimi = n;
        }
        public String palautaNimi()
        {
            return nimi;
        }
        public void laitaLYtunnus(String l)
        {
            nimi = l;
        }
        public String palautaLYtunnus()
        {
            return LYtunnus;
        }
        public void laitaTyontekija(Tyontekija t)
        {
            rekisteri.Add(t);
        }
        public void laitaTyontekijat()
        {
            String[,] tyontekijat = { {"Paavo Käkkäräinen", "AA324"},
                                      {"Sakari Sorja", "AA452"},
                                      {"Tepi Kuusisto", "BB335"},
                                      {"Keijo Kuukka", "BB374"},
                                      {"Jarmo Rinne", "CC234"} };

            Random sl = new Random();

            for (int i = 0; i < 5; i++)
            {
                int sv = sl.Next(1980, 2004);
                rekisteri.Add(new Tyontekija(tyontekijat[i, 0], tyontekijat[i, 1], sv));
            }
        }
        public String palautaTyontekijat()
        {
            String tekijat = "";
            for (int k = 0; k < rekisteri.Count; k++)
            {
                //kirjatiedot = kirjatiedot + kirjahylly.ElementAt(k).palautaNimi() + " (s." + kirjahylly.ElementAt(k).palautaSivut() + ") Kirj: " + kirjahylly.ElementAt(k).palautaKirjoittaja() + "\n";
                tekijat = tekijat + rekisteri.ElementAt(k).palautaNimi() + "\n";
            }
            return tekijat;
        }
        public String palautaTyontekijatiedot(int k)
        {
            String tt = "";

            tt = tt + rekisteri.ElementAt(k).palautaNimi() + ":\n" + "Firmakoodi on " + rekisteri.ElementAt(k).palautaFirmakoodi() + "\n" + "Syntymävuosi on " + rekisteri.ElementAt(k).palautaSyntymavuosi() + "\n";

            return tt;
        }
        public int palautaPaikka(String n)
        {
            int paikka = 0;

            for (int k = 0; k < rekisteri.Count; k++)
            {
                if (rekisteri.ElementAt(k).palautaNimi() == n)
                {
                    paikka = k;
                    break;
                }
            }
            return paikka;
        }

    }
}
