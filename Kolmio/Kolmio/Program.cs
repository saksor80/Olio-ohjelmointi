using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolmio
{
    // Piste-luokka
    class Piste
    {
        //  Ominaisuudet, atribuutit
        private int x;
        private int y;

        // Muodostimet
        // Oletusmuodostin
        public Piste()
        {
            Console.WriteLine("Loin todellisen pisteen :)");
        }

        //Parametrisoitu muodostin
        public Piste(int xx, int yy)
        {
            x = xx;
            y = yy;
        }

        // Toiminnot, operaatiot, metodit
        // Getterit ja setterit: laitetaan tiedot, palautetaan tiedot
        public void laitaX(int xx)
        {
            x = xx;
        }

        public void laitaY(int yy)
        {
            y = yy;
        }

        public int palautaX()
        {
            return x;
        }

        public int palautaY()
        {
            return y;
        }

        public String palautaPisteTiedot()
        {
            String p = "(" + x + "," + y + ")";
            return p;
        }
    }
    // Kolmio-luokka
    class Kolmio
    {
        // Viitataan Piste-luokkaan, että saadaan muodostettua kolmion kärkipisteet
        private Piste p1;
        private Piste p2;
        private Piste p3;

        // Muodostetaan kolmio
        public void AsetaKolmio(Piste kp1, Piste kp2, Piste kp3)
        {
            p1 = kp1;
            p2 = kp2;
            p3 = kp3;
        }

        // Toiminto palauttaa kolmion kärkipisteiden tiedot
        public String palautaKolmionTiedot()
        {
            String info = "Kolmion kärkipisteet ovat: " + p1.palautaPisteTiedot() + ", " +
                   p2.palautaPisteTiedot() + " ja " + p3.palautaPisteTiedot();
            return info;
        }

        //Toiminto palauttaa pinta-alan
        public double palautaPintaAla()
        {
            // Ensin lasketaan sivujen pituudet
            double s1 = Math.Sqrt((p1.palautaX() - p2.palautaX()) * (p1.palautaX() - p2.palautaX()) + (p1.palautaY() - p2.palautaY()) * (p1.palautaY() - p2.palautaY()));

            double s2 = Math.Sqrt((p1.palautaX() - p3.palautaX()) * (p1.palautaX() - p3.palautaX()) + (p1.palautaY() - p3.palautaY()) * (p1.palautaY() - p3.palautaY()));

            double s3 = Math.Sqrt((p2.palautaX() - p3.palautaX()) * (p2.palautaX() - p3.palautaX()) + (p2.palautaY() - p3.palautaY()) * (p2.palautaY() - p3.palautaY()));

            // Käytetään Heronin kaavaa Pinta-alan laskentaan: sijoitetaan sivujen pituudet
            double s = (s1 + s2 + s3) / 2;

            double pala = Math.Sqrt(s * (s - s1) * (s - s2) * (s - s3));

            return pala;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Piste p1 = new Piste(1, 3);
            Piste p2 = new Piste(2, 5);
            Piste p3 = new Piste(7, 2);

            Kolmio k1 = new Kolmio();
            k1.AsetaKolmio(p1, p2, p3);

            Console.WriteLine("{0}", k1.palautaKolmionTiedot());
            Console.WriteLine("Kolmion pinta-ala on: " + k1.palautaPintaAla());

            Console.Read();
        }
    }
}
