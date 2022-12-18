using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linnut
{
    class Lintukokoelma
    {
        private List <Muuttolintu> linnut = new List<Muuttolintu> ();

        public void laitaLintu(Muuttolintu ml)
        {
            linnut.Add(ml);
        }
        public String palautaLinnut()
        {
            String lintutiedot = "";
            for (int k = 0; k < linnut.Count; k++)
            {
                // Stringiin tulee kyllä rivinvaihto, mutta sitten comboboxissa linnut tulee yhteen
                // samalle riville. Mitenköhän tuon saisi korjattua? Tietysti comboboxiin voisi
                // laittaa aina suoraan .Items.Addilla uuden linnun luonnin yhteydessä ja
                // lista vastaisi siten samaa sisältöä mikä tulee listaan. Tai sitten minulla on tässä vain joku
                // väärin.
                lintutiedot = lintutiedot + linnut.ElementAt(k).palautaNimi() + "\n";
            }
            return lintutiedot;
        }
    }
}
