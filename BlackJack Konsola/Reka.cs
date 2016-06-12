using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Konsola
{
    public class Reka : Talia
    {
        public double Wartosc
        {
            get
            {
                return Dzialanie.PoliczReke(this);
            }
        }
    }
}
