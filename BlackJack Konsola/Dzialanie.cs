using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Konsola
{
    public enum WynikGry { Wygrana = 1, Przegrana = -1, Remis = 0 , Trwa =2}
    public static class Dzialanie
    {

        public static int PoliczReke(Reka reka)
        {
            int wartosc = reka.Sum(karty => karty.Wartosc);

            int asy = reka.Count(karty => karty.Symbol == "A");
            for (int i = 0; i < asy; i++)
            {
                if (wartosc + 10 <= 21)
                    wartosc += 10;
            }
            return wartosc;

        }

        public static bool CzyDealerDobiera(Reka reka)
        {
            return reka.Wartosc < 17;
        }
        public static bool CzyMoznaDobrac(Reka reka)
        {
            return reka.Wartosc < 21;
        }
        public static WynikGry SprawdzWynik(Osoba gracz, Osoba dealer)
        {
            WynikGry wynik = WynikGry.Wygrana;
            int rekaGracza = PoliczReke(gracz.Reka);
            int rekaDealera = PoliczReke(dealer.Reka);

            if (rekaGracza <= 21)
            {
                if (rekaDealera > 21)
                    wynik = WynikGry.Wygrana;

                else if (rekaGracza != rekaDealera)
                {
                    if (rekaGracza > rekaDealera)
                        wynik = WynikGry.Wygrana;
                    else
                        wynik = WynikGry.Przegrana;
                }

                else
                    wynik = WynikGry.Remis;
            }

            else
                wynik = WynikGry.Przegrana;

            return wynik;
        }
    }
}
