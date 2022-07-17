using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame66
{
    public class SpecialCard : Card
    {
        //First card that is flipped and determens dominant suit, can be switched by player with 9 of same suit
        public SpecialCard(Card card) : base(card.Suit, card.Power)
        {

        }

        public void SwitchWithNine(Card card)
        {
            Power = card.Power;
            Value = card.Value;
        }
    }
}
