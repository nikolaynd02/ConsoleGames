using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame66
{
    public class Player
    {
        private string dominantSuit;
        private List<Card> CardsInHand { get; set; } // cannot be more than 6

        public int Score { get; set; }

        public Player(Deck deck)
        {
            CardsInHand = new List<Card>();
            FillHand(deck);
        }

        private void FillHand(Deck deck)
        {
            for(int i = 0; i < 6; i++)
            {
                CardsInHand.Add(deck.Cards[0]);
                deck.Cards.RemoveAt(0);
            }
        }

        private void CheckForDeclaration(Card playedCard)
        {
            if(CardsInHand.Any(card => card.Suit == playedCard.Suit && card.Value + playedCard.Value == 7))
            {
                int scoreToAdd = 20;

                if(playedCard.Suit == dominantSuit)
                {
                    scoreToAdd *= 2;
                }

                Score += scoreToAdd;
            }
        }

        public void DrawCard(Deck deck)
        {
            if(deck.Cards.Count > 0)
            {
                CardsInHand.Add(deck.Cards[0]);
                deck.Cards.RemoveAt(0);
            }
        }

        public void TakesRound(Card firstCard, Card secondCard)
        {
            Score += firstCard.Value + secondCard.Value;
        }

        public Card PlayCard(int index)
        {
            Card card = CardsInHand[index];
            CheckForDeclaration(card);
            CardsInHand.RemoveAt(index);
            return card;
        }
    }
}
