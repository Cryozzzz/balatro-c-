using System;
using System.Collections.Generic;
using balatro.Enums;
using System.Text;

namespace balatro.Classes
{
    internal class Hand
    { 

        private List<Card> cards = new List<Card>();
        private List<Card> selectedCards = new List<Card>();
        public int Count
        {
            get { return cards.Count; }
        }
        public void AddCard (Card card)
        {
            cards.Add(card);
        }
        public void SelectCard(Card card)
        {
            selectedCards.Add(card);
        }
        public void DeselectCard(Card card)
        {
            selectedCards.Remove(card);
        }
        public void ShowCards()
        {
            foreach(Card card in cards)
            {
                Console.WriteLine($"{card.value} of {card.suit}");
            }
        }
        public List<Card> RemoveSelectedCards()
        {
            List<Card> removedCards = new List<Card>();
            foreach (Card card in selectedCards)
            {
                removedCards.Add(card);
                cards.Remove(card);
      
            }
            selectedCards.Clear();
            return removedCards;
        }

        public void SelectAll()
        {
            foreach (Card card in cards)
            {
                selectedCards.Add(card);
            }

        }
    }
}
