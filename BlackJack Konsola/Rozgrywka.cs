using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Konsola
{
    public class Rozgrywka
    {
        public Osoba Dealer = new Osoba();
        public Osoba Gracz = new Osoba();
        public Talia TaliaGlowna;
        public WynikGry Wynik { get; set; }


        public Rozgrywka()
        {
            TaliaGlowna = new Talia().PotasowanaTalia();
            Wynik = WynikGry.Trwa;

            Gracz.Reka.Clear();
            Dealer.Reka.Clear();


            Gracz.Reka.Add(TaliaGlowna.First());
            TaliaGlowna.RemoveAt(0);
            Dealer.Reka.Add(TaliaGlowna.First());
            TaliaGlowna.RemoveAt(0);
            Gracz.Reka.Add(TaliaGlowna.First());
            TaliaGlowna.RemoveAt(0);
        }
        public void Hit() {
            if (Dzialanie.CzyMoznaDobrac(Gracz.Reka) && Wynik == WynikGry.Trwa) {
                Gracz.Reka.Add(TaliaGlowna.First());
                TaliaGlowna.RemoveAt(0);
                if (!Dzialanie.CzyMoznaDobrac(Gracz.Reka)){
                    this.Stand();
                }
            }
        }

        public void Stand() {
            if (Wynik == WynikGry.Trwa) {
                while (Dzialanie.CzyDealerDobiera(Dealer.Reka)) {
                    Dealer.Reka.Add(TaliaGlowna.First());
                    TaliaGlowna.RemoveAt(0);
                }
            }
            Wynik = Dzialanie.SprawdzWynik(Gracz, Dealer);
        }
    }
}
