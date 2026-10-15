using balatro.Classes;
using balatro.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using balatro.Enums;




namespace balatro.Classes.Handtype_s
{
    internal class HighCard
    {

        public HandScore GetScore(List<Card> playedCards)
            {
                int highestValue = 0;
                foreach(Card cards in playedCards)
                {
                    if ((int) cards.value > highestValue)
                    {
                        highestValue = (int) cards.value;
    }

}
return new HandScore(1, highestValue, HandType.HighCard);
            }



    }
}
