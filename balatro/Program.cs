using balatro.Classes;
using balatro.Enums;

Deck deck = new Deck();
Hand hand = new Hand();
Round round = new Round(deck,hand);

deck.Shuffle();
hand.ShowCards();
Card firstCard = deck.DrawCard();
Card secondCard = deck.DrawCard();
hand.AddCard(firstCard);
hand.AddCard(secondCard);
for (int i = 0; i < 4; i++)
{
    hand.AddCard(deck.DrawCard());
}

hand.SelectAll();

round.PlayHand();
hand.ShowCards();

Console.WriteLine("Cards in hand: " + hand.Count);
Console.WriteLine("Points: " + round.Points);