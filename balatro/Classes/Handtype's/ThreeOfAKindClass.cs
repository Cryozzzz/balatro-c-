using System;
using System.Collections.Generic;
using System.Text;
using balatro.Classes;
using balatro.Enums;

namespace balatro.Classes.Handtype_s
{
    internal class ThreeOfAKind
    {
        public HandScore GetThreeOfAKind(List<Card> playedCards)
        {
            int cardValue = 0;
            List<Card> scoringCards = new List<Card>();
            int scoringPoints = 0;

            foreach (Card card in playedCards)
            {
                int count = 0;

                foreach (Card otherCard in playedCards)
                {
                    if (otherCard.value == card.value)
                    {
                        count++;
                    }
                }
                if (count == 3)
                {
                    cardValue = (int)card.value;
              
                }
            }
            foreach (Card card in playedCards)
            {
                if (cardValue == (int)card.value)
                {
                    scoringCards.Add(card);
                }
            }

            foreach (Card card in scoringCards)
            {
                scoringPoints += (int)card.value;
            }

            return new HandScore(3, scoringPoints, HandType.ThreeOfAKind);
        }

        public bool HasThreeOfAKind(List<Card> playedCards)
        {

            foreach (Card card in playedCards)
            {
                int count = 0;

                foreach (Card otherCard in playedCards)
                {

                    if (otherCard.value == card.value)
                    {
                        count++;
                    }
                    if (count == 3)
                    {
                        return true;
                    }


                }


            }
            return false;
        }

    }
    
}
