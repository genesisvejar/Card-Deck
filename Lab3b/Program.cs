using System;
using System.Collections.Generic; 
using Cards2;

// Add your code between this comment
// and the comment below. You can of
// course add more space between the
// comments as needed

// declare a deck variables and create a deck object
// DON'T SHUFFLE THE DECK

Deck deck1 = new Deck();

// deal 2 cards each to 4 players (deal properly, dealing
// the first card to each player before dealing the
// second card to each player)
List<Card>[] players = new List<Card>[4];

for (int i = 0; i < 4; i++)
{
    players[i] = new List<Card>();

}

for (int r = 0; r < 2; r++)
{
    for (int i = 0; i < 4; i++)
    {

        players[i].Add(deck1.TakeTopCard());


    }
}



Console.WriteLine($"2 Cards for each players");  
for (int i = 0; i < 4; i++)
{

    Console.WriteLine($"Player {i + 1}: ");
    foreach (Card c in players[i])
    {
        Console.WriteLine($"{c.Rank} of {c.Suit}");


    }
    Console.WriteLine();
}


// deal 1 more card to players 2 and 3
for (int i = 1; i < 3; i++)

{
    players[i].Add(deck1.TakeTopCard());
    players[i].Add(deck1.TakeTopCard());
        
    }

Console.WriteLine($"2 more cards to player 2 and 3");
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine($"Player {i + 1}:");
        foreach (Card c in players[i])
        Console.WriteLine($"{c.Rank} of {c.Suit}");
        Console.WriteLine();
    }


// flip all the cards over

for (int i = 0; i < 4; i++)
{
    foreach (Card c in players[i])
    {
        c.FlipOver();

    }

}


Console.WriteLine($"Dealt cards");

for (int i = 0; i < players.Length; i++)
{
    Console.WriteLine($"Player {i + 1}: ");

    foreach (Card c in players[i])
    {
        // print the cards for player 1
        if (i == 0)
        {
            Console.WriteLine($"{c.Rank} of {c.Suit}");
        }
        // print the cards for player 2

        else if (i == 1)
        {
            Console.WriteLine($"{c.Rank} of {c.Suit}");
        }

        // print the cards for player 3
        else if (i == 2)
        {
            Console.WriteLine($"{c.Rank} of {c.Suit}");
        }
        // print the cards for player 4
        else if (i == 3)
        {
            Console.WriteLine($"{c.Rank} of {c.Suit}");
        }



    }
    Console.WriteLine();
}








