using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antikvariaatti
{
    class Antikvariaatti
    {
        private string osoite;
        private Omistaja omistaja;
        public List<Kirja> kirjahylly = new List<Kirja>();

        public Antikvariaatti()
        { }
        public Antikvariaatti(String o, Omistaja oo)
        {
            osoite = o;
            omistaja = oo;
        }
        public void laitaOsoite(String o)
        {
            osoite = o;
        }
        public String palautaOsoite()
        {
            return osoite;
        }
        public void laitaOmistaja(Omistaja oo)
        {
            omistaja = oo;
        }
        public void laitaKirja(Kirja k)
        {
            kirjahylly.Add(k);
        }
        public void laitaKirjat()
        {
            String[,] kirjat = { {"One Flew Over the Cuckoos Nest", "Ken Kesey"},
                                 {"A Tale of Two Cities", "Charles Dickens"},
                                 {"The Three Musketeers", "Alexandre Dumas"},
                                 {"The Sign of the Four", "Arthur Conan Doyle"},
                                 {"High Five", "Janet Evanovich"},
                                 {"Six Years", "Harlan Coben"},
                                 {"Seven Years in Tibet", "Heinrich Harrer"},
                                 {"The Eight", "Katherine Neville"},
                                 {"Nine Lives to Die", "Rita Mae Brown"},
                                 {"Ten Little Ladybugs", "Melanie Gerth"},
                                 {"Eleven Birthdays", "Wendy Mass"},
                                 {"Twelve Years a Slave", "Solomon Northup"},
                                 {"Thirteen Reasons Why", "Jay Asher"},
                                 {"Fourteen", "Peter Clines"},
                                 {"Fifteen Minutes", "Karen Kingsbury"},
                                 {"Sixteen Cows", "Lisa Wheeler"},
                                 {"At Seventeen", "Gerri Hill"},
                                 {"Eighteen Summers", "Jessie M"},
                                 {"Nineteen Minutes", "Jodi Picoult"},
                                 {"Twenty Thousand Leagues Under the Sea", "Jules Verne"},
                                 {"The Twenty-One Balloons", "William Pene du Bois"},
                                 {"Catch-22", "Joseph Heller"},
                                 {"Twenty-Three Tales", "Leo Tolstoy"},
                                 {"The Twenty-Four Days Before Christmas", "Madeleine L’Engle"},
                                 {"Twenty-Five", "Rachel L. Hamm"},
                                 {"Twenty-Six Roses", "Tamara Vann"},
                                 {"Twenty-Seven Bones", "Jonathan Nasaw"},
                                 {"Twenty-Eight and a Half Wishes", "Denise Grover Swank"},
                                 {"The Rabbi and the Twenty-Nine Witches", "Marilyn Hirsh"},
                                 {"Thirty Seconds", "Heather MacPherson"},
                                 {"Thirty-One Dates in Thirty-One Days", "Tamara Duricka Johnson"},
                                 {"Thirty-Two Going on Spinster", "Becky Monson"},
                                 {"Thirty-Three Teeth", "Colin Cotterill"},
                                 {"The 34th Degree", "Thomas Greanias"},
                                 {"Stranger on Route Thirty-Five", "Leslie Sansom"},
                                 {"Thirty-Six Hours", "Allison Brennan"},
                                 {"Thirty-Seven", "Maria Beaumont"},
                                 {"Thirty-Eight Nooses", "Scott W. Berg"},
                                 {"The Thirty-Nine Steps", "John Buchan"},
                                 {"North Dallas Forty", "Peter Gent"},
                                 {"Forty-One Jane Doe’s", "Carrie Olivia Adams"},
                                 {"Forty-Two", "M. Thomas Cooper"},
                                 {"Forty-Three Septembers", "Jewelle Gomez"},
                                 {"Forty-Four", "Jools Sinclair"},
                                 {"Forty-Five", "Bill Drummond"},
                                 {"Forty-Six Pages", "Scott Liell"},
                                 {"Forty-Seven Kisses", "Victoria Grant"},
                                 {"Forty-Eight X", "Barry Pollack"},
                                 {"The Crying of Lot 49", "Thomas Pynchon"},
                                 {"The Fifty Year Sword", "Mark Z. Danielewski"},
                                 {"Fifty-One Tales", "Edward J.M.D. Plunkett"},
                                 {"Fifty-Two Pickup", "Elmore Leonard"},
                                 {"Fifty Three", "Rosanita Ratcliff"},
                                 {"Fifty-Four", "Wu Ming"},
                                 {"Fifty-Five Graves", "Robert P. Maroney"},
                                 {"Fifty-Six Men", "Fred Placke"},
                                 {"The Fifty-Seven Lives of Alex Wayfare", "M.G. Buehrlen"},
                                 {"The Folks at Fifty-Eight", "Michael Patrick Clark"},
                                 {"Fifty-Nine in ’84", "Edward Achorn"},
                                 {"The House of Sixty Fathers", "Meindert DeJong"} };

            Random sl = new Random();

            for (int i = 0; i < 60; i++)
            {
                int sm = sl.Next(10, 2000);
                kirjahylly.Add(new Kirja(kirjat[i,0],sm,new Kirjoittaja(kirjat[i,1],kirjat[i, 1].Substring(kirjat[i, 1].IndexOf(' ') + 1) + "@kirjailija.com")));
            }
        }
        public String palautaKirjat()
        {
            String kirjat = "";
            for (int k = 0; k < kirjahylly.Count; k++)
            {
                //kirjatiedot = kirjatiedot + kirjahylly.ElementAt(k).palautaNimi() + " (s." + kirjahylly.ElementAt(k).palautaSivut() + ") Kirj: " + kirjahylly.ElementAt(k).palautaKirjoittaja() + "\n";
                kirjat = kirjat + kirjahylly.ElementAt(k).palautaNimi() + "\n";
            }
            return kirjat;
        }
        public String palautaKirjatiedot(int k)
        {
            String kirjatiedot = "";
   
            kirjatiedot = kirjatiedot + kirjahylly.ElementAt(k).palautaNimi() + ":\n" + "Sivumäärä on " + kirjahylly.ElementAt(k).palautaSivut() + "\n" + "Kirjoittaja on " + kirjahylly.ElementAt(k).palautaKirjoittaja() + "\n";
            
            return kirjatiedot;
        }
        public int palautaPaikka(String n)
        {
            int paikka = 0;

            for (int k = 0; k < kirjahylly.Count; k++)
            {
             if(kirjahylly.ElementAt(k).palautaNimi() == n)
                {
                    paikka = k;
                    break;
                }
            }
            return paikka;
        }
    }
}
