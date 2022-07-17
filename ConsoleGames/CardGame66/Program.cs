using System;

namespace CardGame66
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: add dominant suit logic, computer class and logic and whos turn is it in the given round

            bool playerTurn = false; // if true, player should act first 

            Deck deck = new Deck();
            SpecialCard specialCard = new SpecialCard(deck.DrawCard());

            string dominantSuit = specialCard.Suit;
            
        }
    }
}
