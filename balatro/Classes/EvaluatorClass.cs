using System;
using System.Collections.Generic;
using System.Text;
using balatro.Enums;

namespace balatro.Classes
{
    internal class Evaluator
    {
        public int Evaluate(List<Card> playedCards)
        {
            int totalPoints = 0;

            foreach (Card card in playedCards)
            {
                int points = (int)card.value;
                totalPoints = totalPoints + points;
            }


            return totalPoints;
        }
    }
}
