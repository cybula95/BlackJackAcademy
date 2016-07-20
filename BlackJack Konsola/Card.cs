using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Konsola
{
    public class Card
    {
        public string Symbol { get; set; }
        public string Color { get; set; }
        public int Value { get; set; }

        public Card(string symbol, string color, int value) {
            Symbol = symbol;
            Color = color;
            Value = value;
        }
    }

}
