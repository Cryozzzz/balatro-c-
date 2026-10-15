using balatro.Classes;
using balatro.Enums;
using System.Collections.Generic;

Deck deck = new Deck();
Hand hand = new Hand();
Round round = new Round(deck,hand);
Evaluator evaluator = new Evaluator();


Card testCard = new Card
{
    value = Value.Seven,
    suit = Suit.Hearts
};
Card testCard2 = new Card
{
    value = Value.Seven,
    suit = Suit.Spades
};
Card testCard3 = new Card
{
    value = Value.Seven,
    suit = Suit.Diamonds
};
List<Card> testCards = new List<Card>();

testCards.Add(testCard);
testCards.Add(testCard2);
testCards.Add(testCard3);


HandScore result = evaluator.Evaluate(testCards);

Console.WriteLine(result.HandType);
Console.WriteLine(result.Points);
Console.WriteLine(result.Multi);