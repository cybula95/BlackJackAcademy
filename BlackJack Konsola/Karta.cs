using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Konsola
{
    public class Karta
    {
        public string Symbol { get; set; }
        public string Kolor { get; set; }
        public int Wartosc { get; set; }

        public Karta(string symbol, string kolor, int value) {
            Symbol = symbol;
            Kolor = kolor;
            Wartosc = value;
        }
    }

}
