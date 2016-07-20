using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Konsola
{
    public class Game
    {
        public Person Dealer = new Person();
        public Person Player = new Person();
        public Deck MainDeck;
        public GameResult Result { get; set; }


        public Game()
        {
            MainDeck = new Deck().ShuffledDeck();
            Result = GameResult.Pending;

            Player.Hand.Clear();
            Dealer.Hand.Clear();


            Player.Hand.Add(MainDeck.First());
            MainDeck.RemoveAt(0);
            Dealer.Hand.Add(MainDeck.First());
            MainDeck.RemoveAt(0);
            Player.Hand.Add(MainDeck.First());
            MainDeck.RemoveAt(0);
        }
        public void Hit() {
            if (Operate.IsHitPossible(Player.Hand) && Result == GameResult.Pending) {
                Player.Hand.Add(MainDeck.First());
                MainDeck.RemoveAt(0);
                if (!Operate.IsHitPossible(Player.Hand)){
                    this.Stand();
                }
            }
        }

        public void Stand() {
            if (Result == GameResult.Pending) {
                while (Operate.DoesDealerHit(Dealer.Hand)) {
                    Dealer.Hand.Add(MainDeck.First());
                    MainDeck.RemoveAt(0);
                }
            }
            Result = Operate.CheckResult(Player, Dealer);
        }
    }
}
