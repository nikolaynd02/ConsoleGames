using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame66
{
    public class Card
    {
        public Card(string suit, string power)
        {
            this.Suit = suit;
            this.Power = power;
            SetValue(power);
        }

        public string Suit { get; set; } // clubs, diamonds, hearts or spades
        public string Power { get; set; } // A > 10 > K > Q > j > 9 
        public int Value { get; set; }  // 9 = 0p, 10 = 10p, J = 2p, Q = 3p, K = 4p, A = 11p

        private void SetValue(string power)
        {
            switch (power)
            {
                case "9":
                    this.Value = 0;
                    break;
                case "J":
                    this.Value = 2;
                    break;
                case "Q":
                    this.Value = 3;
                    break;
                case "K":
                    this.Value = 4;
                    break;
                case "10":
                    this.Value = 10;
                    break;
                case "A":
                    this.Value = 11;
                    break;
            }
        }
    }
}
