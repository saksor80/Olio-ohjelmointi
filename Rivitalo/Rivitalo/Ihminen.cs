using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivitalo
{
    class Ihminen
    {
        protected String nimi;
        protected int syntymavuosi;
        public Ihminen()
        { }

        public Ihminen(String n)
        {
            nimi = n;
        }
        public void laitaNimi(String n)
        {
            nimi = n;
        }
        public String palautaNimi()
        {
            return nimi;
        }
        public void laitaSyntymavuosi(int v)
        {
            syntymavuosi = v;
        }
        public int palautaSyntymavuosi()
        {
            return syntymavuosi;
        }
    }
}
