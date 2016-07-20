using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Konsola
{
    public class Card
    {
        public string Symbol { get; }
        public string Color { get; }
        public int Value { get; }

        public Card(string symbol, string color, int value)
        {
            Symbol = symbol;
            Color = color;
            Value = value;
        }
    }

}
