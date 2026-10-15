using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using balatro.Enums;
using balatro.Classes.Handtype_s;

namespace balatro.Classes
{
    internal class Evaluator
    {


        public HandScore Evaluate(List<Card> playedCards)
        {
            HighCard highCard = new HighCard();
            Pair pair = new Pair();
            ThreeOfAKind threeOfAKind = new ThreeOfAKind();

            //test


            if (threeOfAKind.HasThreeOfAKind(playedCards))
            {
                return threeOfAKind.GetThreeOfAKind(playedCards);
            }
        
            else if(pair.HasPair(playedCards)){
                return pair.GetPair(playedCards);
            }
            
            else
            {
                return highCard.GetScore(playedCards);
            }


        }
    }
}
