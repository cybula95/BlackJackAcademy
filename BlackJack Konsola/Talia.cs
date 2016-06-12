using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Konsola
{

    public class Talia : List<Karta>
    {
        public static string[] symbole = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "Q", "K" };

        public static string[] kolory = { "Kier", "Karo", "Trefl", "Pik" };

        public void NowaTalia()
        {
            int wartosc;
            foreach (string kolor in kolory)
            {
                foreach (string symbol in symbole)
                {
                    wartosc = Int32.TryParse(symbol, out wartosc) ? wartosc : symbol == "A" ? 1 : 10;
                    this.Add(new Karta(symbol, kolor, wartosc));
                }
            }
        }
        public Talia PotasowanaTalia()
        {
            Talia DoTasowania = new Talia();
            Talia Potasowana = new Talia();
            DoTasowania.NowaTalia();
            Random rand = new Random();
            int nastepna;
            while (DoTasowania.Count !=0)
            {
                nastepna = rand.Next(0, DoTasowania.Count - 1);
                Potasowana.Add(DoTasowania[nastepna]);
                DoTasowania.RemoveAt(nastepna);
            }
            Console.WriteLine("Potasowano");
            return Potasowana;
        }
        public Karta this[int index]
        {
            get
            {
                Karta item;
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
