using System;
using System.Collections.Generic;
using System.Text;

namespace balatro.Classes
{
    internal class Round
    {
        private Deck deck;
        private Hand hand;
        private Evaluator evaluator = new Evaluator();
        private int totalCardsPoints;
        public int Points
        {
            get { return totalCardsPoints; }
        }
        public Round(Deck deck, Hand hand)
        {
            this.deck = deck;
            this.hand = hand;
        }
        public void PlayHand()
        {
            List<Card> playedCards = hand.RemoveSelectedCards();
            int cardsPoints = evaluator.Evaluate(playedCards);
            totalCardsPoints += cardsPoints;
            int cardsNeeded = 8 - hand.Count;
            for (int i = cardsNeeded; i > 0; i--)
            {
                hand.AddCard(deck.DrawCard());
            }
        }
    }
}
