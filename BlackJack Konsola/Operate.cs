using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Konsola
{
    public enum GameResult { Won = 1, Lost = -1, Tie = 0 , Pending =2}
    public static class Operate
    {

        public static int CountHand(Hand hand)
        {
            int value = hand.Sum(cards => cards.Value);

            int aces = hand.Count(cards => cards.Symbol == "A");
            for (int i = 0; i < aces; i++)
            {
                if (value + 10 <= 21)
                    value += 10;
            }
            return value;

        }

        public static bool DoesDealerHit(Hand hand)
        {
            return hand.Value < 17;
        }
        public static bool IsHitPossible(Hand hand)
        {
            return hand.Value < 21;
        }
        public static GameResult CheckResult(Person player, Person dealer)
        {
            GameResult result = GameResult.Won;
            int playersHand = CountHand(player.Hand);
            int dealersHand = CountHand(dealer.Hand);

            if (playersHand <= 21)
            {
                if (dealersHand > 21)
                    result = GameResult.Won;

                else if (playersHand != dealersHand)
                {
                    if (playersHand > dealersHand)
                        result = GameResult.Won;
                    else
                        result = GameResult.Lost;
                }

                else
                    result = GameResult.Tie;
            }

            else
                result = GameResult.Lost;

            return result;
        }
    }
}
