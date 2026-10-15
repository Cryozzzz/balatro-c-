using System;
using System.Collections.Generic;
using System.Text;
using balatro.Classes;
using balatro.Enums;

namespace TestProject1
{
    public class DeckTests
    {
        [Fact]
        public void DeckStartsWith52Cards()
        {
            Deck deck = new Deck();

            Assert.Equal(52, deck.Count);
        }
        [Fact]
        public void DrawCardReducesDeckCount()
        {
            Deck deck = new Deck();
            int deckCount = deck.Count;
            Card drawnCard = deck.DrawCard();
            Assert.NotNull(drawnCard);
            Assert.Equal(deckCount - 1, deck.Count);

        }
        [Fact]
        public void DrawingAllCardsLeavesDeckEmpty()
        {
            Deck deck = new Deck();


            while (deck.Count > 0)
            {
                deck.DrawCard();
            }
            Assert.Equal(0, deck.Count);
        }
        [Fact]
        public void DrawingFromEmptyDeckThrowsException()
        {
            Deck deck = new Deck();

            while (deck.Count > 0)
            {
                deck.DrawCard();
            }

            Assert.Throws<ArgumentOutOfRangeException>(() => deck.DrawCard());
        }
        [Fact]
        public void ShuffleKeepsDeckCount()
        {
            Deck deck = new Deck();
            int deckCount = deck.Count;
            deck.Shuffle();
            Assert.Equal(deckCount, deck.Count);
        }
    }
}




