﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Konsola
{
    public class Hand : Deck
    {
        public double Value
        {
            get
            {
                return Operate.CountHand(this);
            }
        }
    }
}
