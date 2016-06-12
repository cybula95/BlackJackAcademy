using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Konsola
{
    class Program
    {
        public static void PokazStan(Rozgrywka gra)
        {

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Dealer:");
            foreach (Karta k in gra.Dealer.Reka)
            {
                Console.WriteLine(string.Format("{0} {1}", k.Symbol, k.Kolor));
            }
            Console.WriteLine("\nSuma: " + gra.Dealer.Reka.Wartosc);

            Console.WriteLine("\nGracz:");
            foreach (Karta k in gra.Gracz.Reka)
            {
                Console.WriteLine(string.Format("{0} {1}", k.Symbol, k.Kolor));
            }
            Console.WriteLine("\nSuma: " + gra.Gracz.Reka.Wartosc);


        }
        static void Main(string[] args)
        {

            Console.WriteLine("BLACK JACK v1.0");
            Console.WriteLine("h/H - Hit");
            Console.WriteLine("s/S - Stand");
            Console.WriteLine("Milej Gry");

            while (true)
            {
                string input = "";
                Rozgrywka gra = new Rozgrywka();


                PokazStan(gra);
                while (gra.Wynik == WynikGry.Trwa)
                {
                    input = Console.ReadLine();
                    if (input.ToLower() == "h")
                    {
                        gra.Hit();
                    }
                    else if (input.ToLower() == "s")
                    {
                        gra.Stand();
                    }
                    else
                    {
                        Console.WriteLine("Zla komenda. Sprobuj jeszcze raz.");
                    }
                    PokazStan(gra);
                }

                Console.WriteLine("\n" + gra.Wynik + "\n");
                Console.WriteLine("Wpisz cokolwiek, aby rozpoczac nowe rozdanie");
                Console.ReadLine();
            }
        }
    }
}
