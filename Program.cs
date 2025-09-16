 using Cards2;
using System;

Card c1 = new Card(Rank.Ace, Suit.Diamonds);


Console.WriteLine(c1.Rank + " " + c1.Suit);
    
    Console.WriteLine();

    Deck d1 = new Deck();

    d1.Shuffle();

    Card topCard = d1.TakeTopCard();

    Console.WriteLine("The top card is " + topCard.Rank + " of " + topCard.Suit);

    /*topCard.Rank = Rank.Kings; it's read only so the rank can't be assigned
    because it's declared like this:
    public Rank Rank { get; }
    and not like this:
    public Rank Rank { get; set; } */

    Console.WriteLine();

    Console.Write("The shuffled deck is: \n");

    d1.Print();


    
