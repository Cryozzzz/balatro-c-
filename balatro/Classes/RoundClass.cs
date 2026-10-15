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

            if (playedCards.Count == 0)
            {

                 Console.WriteLine("you need to select a card");
                return;
            }

            HandScore cardsPoints = evaluator.Evaluate(playedCards);
            int score = cardsPoints.Points * cardsPoints.Multi;
            totalCardsPoints += score;
            int cardsNeeded = 8 - hand.Count;
            for (int i = cardsNeeded; i > 0; i--)
            {
                hand.AddCard(deck.DrawCard());
            }
        }
    }
}
