using balatro.Classes;
using balatro.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace balatro.Classes.Handtype_s
{
    internal class Pair
    {


        public HandScore GetPair(List<Card> playedCards)
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
                if (count == 2 )
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

            return new HandScore(2, scoringPoints, HandType.Pair);
        }

        public bool HasPair(List<Card> playedCards)
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
                    if (count == 2)
                    {
                        return true;
                    }
                  

                }
      

            }
            return false;
        }



    }
}
