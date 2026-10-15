using balatro.Classes;
using balatro.Enums;

namespace TestProject1
{
    public class CardTests
    {
        [Fact]
        public void CardStoresSuitAndValues()
        {
            Card card = new Card();
            card.suit = Suit.Hearts;
            card.value = Value.Seven;

            Assert.Equal(Suit.Hearts, card.suit);
            Assert.Equal(Value.Seven, card.value);

        }
    }
}
