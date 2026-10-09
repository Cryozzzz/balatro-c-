using balatro.Enums;
using System.Security.Cryptography.X509Certificates;

namespace balatro.Classes
{
    internal class Deck
    {
        private List<Card> cards = new List<Card>();
        public int Count
        {
            get { return cards.Count; }
        }
        public Deck()
        {

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value value in Enum.GetValues(typeof(Value)))
                {
                    Card card = new Card();
                    card.suit = suit;
                    card.value = value;
                    cards.Add(card);

                }

            }
        }
        public Card DrawCard()
        {
            Random random = new Random();
            int index = random.Next(cards.Count);
            Card drawnCard = cards[index];
            cards.RemoveAt(index);
            return drawnCard;


        }

        public void Shuffle()
        {

            Random random = new Random();
            for (int i = 0; i < cards.Count; i++) {
                int index1 = random.Next(cards.Count);
                int index2 = random.Next(cards.Count);

                Card temp = cards[index1];
                cards[index1] = cards[index2];
                cards[index2] = temp;
            }

        }
    }
    
}







