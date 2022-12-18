using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linnut
{
    class Muuttomaa
    {
        private String maanimi;

        public void laitaMaa(String m)
        {
            maanimi = m;
        }

        public String palautaMaa()
        {
            return maanimi;
        }
    }
}
