using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame66
{
    public class Deck
    {
        public List<Card> Cards { get; set; }  //24 cards total

        public Deck()
        {
            this.Cards = new List<Card>();
            GenerateDeck();
        }

        private void GenerateDeck() // generates random deck
        {
            int cardsCount = 0;

            List<string> suitsToChoose = new List<string>()
            {
                "clubs",
                "diamonds",
                "hearts",
                "spades"
            };

            List<string> powersToChoose = new List<string>()
            {
                "9",
                "J",
                "Q",
                "K",
                "10",
                "A"
            };

            Dictionary<string,int> suits = new Dictionary<string, int>()
            {
                ["clubs"] = 0,
                ["diamonds"] = 0,
                ["hearts"] = 0,
                ["spades"] = 0
            };

            Dictionary<string, int> powers = new Dictionary<string, int>()
            {
                ["9"] = 0,
                ["J"] = 0,
                ["Q"] = 0,
                ["K"] = 0,
                ["10"] = 0,
                ["A"] = 0
            };

            while (cardsCount++ < 24)
            {
                Random randomNum = new Random();


                string currCardSuit = suitsToChoose[randomNum.Next(0, suitsToChoose.Count)];
                string currCardPower = powersToChoose[randomNum.Next(0, powersToChoose.Count)];

                suits[currCardSuit]++;
                if(suits[currCardSuit] == 6)
                {
                    suitsToChoose.Remove(currCardSuit);
                }

                powers[currCardPower]++;
                if (powers[currCardPower] == 4)
                {
                    powersToChoose.Remove(currCardPower);
                }

                Card currCard = new Card(currCardSuit, currCardPower);

                Cards.Add(currCard);
            }

        }
    }
}
