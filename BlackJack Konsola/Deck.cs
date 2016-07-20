using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Konsola
{

    public class Deck : List<Card>
    {
        public static string[] symbols = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "Q", "K" };

        public static string[] colors = { "Kier", "Karo", "Trefl", "Pik" };

        public void NewDeck()
        {
            int value;
            foreach (string color in colors)
            {
                foreach (string symbol in symbols)
                {
                    value = Int32.TryParse(symbol, out value) ? value : symbol == "A" ? 1 : 10;
                    this.Add(new Card(symbol, color, value));
                }
            }
        }
        public Deck ShuffledDeck()
        {
            Deck ToShuffle = new Deck();
            Deck Shuffled = new Deck();
            ToShuffle.NewDeck();
            Random rand = new Random();
            int next;
            while (ToShuffle.Count !=0)
            {
                next = rand.Next(0, ToShuffle.Count - 1);
                Shuffled.Add(ToShuffle[next]);
                ToShuffle.RemoveAt(next);
            }
            Console.WriteLine("Potasowano");
            return Shuffled;
        }
        public Card this[int index]
        {
            get
            {
                Card item;
                if (index >= 0 && index <= this.Count - 1)
                {
                    item = this.ToArray()[index];
                }
                else
                {
                    item = null;
                }
                return item;
            }
        }


    }
}
