using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Konsola
{
    class Program
    {
        private static void ShowState(Game game)
        {

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Dealer:");
            foreach (Card k in game.Dealer.Hand)
            {
                Console.WriteLine(string.Format("{0} {1}", k.Symbol, k.Color));
            }
            Console.WriteLine("\nSuma: " + game.Dealer.Hand.Value);

            Console.WriteLine("\nGracz:");
            foreach (Card k in game.Player.Hand)
            {
                Console.WriteLine(string.Format("{0} {1}", k.Symbol, k.Color));
            }
            Console.WriteLine("\nSuma: " + game.Player.Hand.Value);


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
                Game game = new Game();


                ShowState(game);
                while (game.Result == GameResult.Pending)
                {
                    input = Console.ReadLine();
                    if (input.ToLower() == "h")
                    {
                        game.Hit();
                    }
                    else if (input.ToLower() == "s")
                    {
                        game.Stand();
                    }
                    else
                    {
                        Console.WriteLine("Zla komenda. Sprobuj jeszcze raz.");
                    }
                    ShowState(game);
                }

                Console.WriteLine("\n" + game.Result + "\n");
                Console.WriteLine("Wpisz cokolwiek, aby rozpoczac nowe rozdanie");
                Console.ReadLine();
            }
        }
    }
}
