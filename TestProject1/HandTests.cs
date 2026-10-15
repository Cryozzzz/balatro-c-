
using System.Collections.Generic;
using balatro.Classes;

namespace TestProject1
{
    public class HandTests
    {
        [Fact]
        public void AddCardIncreasesCount()
        {
            Hand hand = new Hand();
            Card card = new Card();
            
            hand.AddCard(card);

            Assert.Equal(1, hand.Count);
        }

        [Fact]
        public void RemoveSelectedCardsRemovesCardFromHand()
        {
            Hand hand = new Hand();
            Card card = new Card();
            hand.AddCard(card);

            hand.SelectCard(card);
            List<Card> removedCards = hand.RemoveSelectedCards();

            Assert.Equal(0, hand.Count);
            Assert.Single(removedCards);
        }
        [Fact]
        public void DeselectCardKeepsCardInHand()
        {
            Hand hand = new Hand();
            Card card = new Card();
            hand.AddCard(card);

            hand.SelectCard(card);
            hand.DeselectCard(card);
            List<Card> removedCards = hand.RemoveSelectedCards();

            Assert.Equal(1, hand.Count);
            Assert.Empty(removedCards);
        }
        [Fact]
        public void SelectAllRemovesAllCardsWhenRemoved()
        {
            Hand hand = new Hand();
            Card card1 = new Card();
            Card card2 = new Card();
            Card card3 = new Card();

            hand.AddCard(card1);
            hand.AddCard(card2);
            hand.AddCard(card3);

            hand.SelectAll();
            List<Card> removedCards = hand.RemoveSelectedCards();

            Assert.Equal(0, hand.Count);
            Assert.Equal(3, removedCards.Count);
        }
    }
}
