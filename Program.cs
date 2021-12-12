using System;
using System.Collections.Generic;

namespace BlackJackCS
{
    class Card
    {
        public string Face { get; set; }
        public string Suit { get; set; }

        override public string ToString()
        {
            return $"The {Face} of {Suit}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cardSuits = new List<string>() { "Spades", "Hearts", "Clubs", "Diamonds" };
            var cardFaces = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            var deck = new List<Card>();

            foreach (var suit in cardSuits)
            {
                foreach (var face in cardFaces)
                {
                    var newCard = new Card()
                    {
                        Suit = suit,
                        Face = face
                    };
                    deck.Add(newCard);
                }
            }
            for (var rightIndex = deck.Count - 1; rightIndex > 1; rightIndex--)
            {
                var randomNumberGenerator = new Random();
                var leftIndex = randomNumberGenerator.Next(rightIndex);
                var leftCard = deck[leftIndex];
                var rightCard = deck[rightIndex];
                deck[rightIndex] = leftCard;
                deck[leftIndex] = rightCard;
            }

        }
    }
}





// class Deck
// {
//     //   - Properties: A list of 52 cards
//     public List<Card> Cards { get; set; } = new List<Card>();

//     public Deck()
//     {
//         //   - Behavior: Make a new deck of 52 shuffled cards. Deal one card out of the deck.
//         CreateDeck();
//         Shuffle();
//     }

//     public void CreateDeck()
//     {
//         // Algorithm B
//         // - Make a new list of the fours suits
//         var suits = new List<string>() { "clubs", "diamonds", "hearts", "spades" };
//         // - Make of a list of 13 ranks and call this list ranks
//         var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
//         // - Make a new list of strings named 'deck'
//         var deck = new List<string>();
//         // - Make a loop that goes through all the suits
//         foreach (var suit in suits)
//         {
//             //   Make a loop that goes through all the 'ranks'
//             //   add newly formed string to the end of the deck list - For Suit = Clubs
//             foreach (var rank in ranks)
//             {
//                 var card = new Card()
//                 {
//                     Suit = suit,
//                     Rank = rank
//                 };
//                 Cards.Add(card);
//             }

//         }
//         // Console.WriteLine(Cards);
//     }
//     public void Shuffle()
//     {

//         var numberOfCards = Cards.Count;
//         for (var rightIndex = numberOfCards - 1; rightIndex >= 1; rightIndex--)
//         {
//             //   leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer"
//             var randomNumberGenerator = new Random();
//             var leftIndex = randomNumberGenerator.Next(rightIndex);
//             // leftIndex = random integer >= 0 and < rightIndex
//             //   Now swap the values at rightIndex and leftIndex by doing this:
//             //   leftCard = the value from deck[leftIndex]
//             var leftCard = Cards[leftIndex];
//             //   rightCard = the value from deck[rightIndex]
//             var rightCard = Cards[rightIndex];
//             //   deck[rightIndex] = leftCard
//             Cards[rightIndex] = leftCard;
//             //   deck[leftIndex] = rightCard
//             Cards[leftIndex] = rightCard;
//         }
//     }
// }

// var deckLength = deck.Count;
// for (var rightIndex = deckLength - 1; rightIndex >= 1; rightIndex--)
// {
//     var randomNumberGenerator = new Random();
//     var leftIndex = randomNumberGenerator.Next(rightIndex);

//     var leftCard = deck[leftIndex];
//     var rightCard = deck[rightIndex];
//     deck[rightIndex] = leftCard;
//     deck[leftIndex] = rightCard;
// }
//         }
//     }

//     class Program
// {
//     static void Main(string[] args)
//     {
//         var usersHand = new List<string>();
//         var dealersHand = new List<string>();


//         usersHand.Add(Deck[0]);
//         usersHand.Add(Deck[1]);
//         dealersHand.Add(deck[2]);
//         dealersHand.Add(deck[3]);



//         Console.WriteLine($"Your hand is {usersHand[0]} and {usersHand[1]}");
//         Console.WriteLine();
//         Console.WriteLine("Please type hit if you'd like to hit or stand if you'd like to stand.");
//         var playersDecision = Console.ReadLine();

//         if (playersDecision == "hit")
//         {
//             usersHand.Add(deck[4]);
//             Console.WriteLine($"Your hand is {usersHand[0]}, {usersHand[1]} and {usersHand[2]}");
//         }




//     }
// }


// ALGORITHM CHECKLIST

// give player option to "hit"
//if player hits, extract next card from shuffled list
// add that card to players hand
// if total of players hand remains <21, player may hit again
// if total of players hand >21, automatic loss for player

// if player "stands" 
// dealer hits until dealers hand >= 17
// if dealers hand >21, automatic loss for dealer

// if playersHand > dealersHand 
// then user wins

// if dealersHand >= playersHand 
// then dealer wins

// prompt option to play again

// if playing again 
// clear both hands
// reshuffle deck

// ORIGINAL ALGORITHM 

// shuffle deck of cards & assign to a list
// assign top two items to playersHand
// assign next two items to dealersHand

// display playersHand to player

// give player option to "hit"
//if player hits, extract next card from shuffled list
// add that card to players hand
// if total of players hand remains <21, player may hit again
// if total of players hand >21, automatic loss for player

// if player "stands" 
// dealer hits until dealers hand >= 17
// if dealers hand >21, automatic loss for dealer

// if playersHand > dealersHand 
// then user wins

// if dealersHand >= playersHand 
// then dealer wins

// prompt option to play again

// if playing again 
// clear both hands
// reshuffle deck






// using System;
// using System.Collections.Generic;

// namespace Blackjack
// {
//     class Program
//     {
//         // # Data Structure

//         // The following Nouns exist in the description of the "P"roblem:

//         // - Deck
//         // - Card
//         // - Hand
//         // - Player
//         // - Dealer

//         // These have the following STATE (properties) and BEHAVIOR (methods)



//         // - Card

//         //   - Properties: The Face of the card, the Suit of the card
//         //   - Behaviors:
//         //     - The Value of the card according to the table in the "P"roblem part

//         // - Hand

//         //   - Properties: A list of individual Cards
//         //   - Behaviors:
//         //     - TotalValue representing he sum of the individual Cards in the list.
//         //       - Start with a total = 0
//         //       - For each card in the hand do this:
//         //         - Add the amount of that card's value to total
//         //       - return "total" as the result
//         //     - Add a card to the hand
//         //       - Adds the supplied card to the list of cards

//         // - Player is just an instance of the Hand class
//         // - Dealer is just an instance of the Hand class
//         // 1.  Create a new deck
//         //     PEDAC ^^^^ - Properties: A list of 52 cards
//         //     Algorithm for making a list of 52 cards

//         //         Make a blank list of cards
//         //         Suits is a list of "Club", "Diamond", "Heart", or "Spade"
//         //         Faces is a list of 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King, or Ace
//         //         ```
//         //         Go through all of the suits one at a time and in order
//         //         {
//         //             Get the current suit
//         //             Go through all of the faces one a time and in order
//         //             {
//         //                 Get the current face

//         //                 With the current suit and the current face, make a new card
//         //                 Add that card to the list of cards
//         //             Go to the card and loop again
//         //             }
//         //         Go to the next suit and loop again
//         //         }
//         //         ```

//         // 2.  Ask the deck to make a new shuffled 52 cards
//         // 3.  Create a player hand
//         // 4.  Create a dealer hand
//         // 5.  Ask the deck for a card and place it in the player hand
//         // 6.  Ask the deck for a card and place it in the player hand
//         // 7.  Ask the deck for a card and place it in the dealer hand
//         // 8.  Ask the deck for a card and place it in the dealer hand
//         // 9.  Show the player the cards in their hand and the TotalValue of their Hand
//         // 10. If they have BUSTED (hand TotalValue is > 21), then goto step 15
//         // 11. Ask the player if they want to HIT or STAND
//         // 12. If HIT
//         //     - Ask the deck for a card and place it in the player hand, repeat step 10
//         // 13. If STAND then continue on
//         // 14. If the dealer's hand TotalValue is more than 21 then goto step 17
//         // 15. If the dealer's hand TotalValue is less than 17
//         //     - Add a card to the dealer hand and go back to 14
//         // 16. Show the dealer's hand TotalValue
//         // 17. If the player's hand TotalValue > 21 show "DEALER WINS"
//         // 18. If the dealer's hand TotalValue > 21 show "PLAYER WINS"
//         // 19. If the dealer's hand TotalValue is more than the player's hand TotalValue then show "DEALER WINS", else show "PLAYER WINS"
//         // 20. If the value of the hands are even, show "DEALER WINS"

//         public class Card
//         {
//             public string Suit { get; set; }

//             public string Rank { get; set; }

//             public int Value()
//             {
//                 // if 2-10 --> value = 2-10
//                 if (Rank == "2")
//                 {
//                     return 2;
//                 }
//                 if (Rank == "3")
//                 {
//                     return 3;
//                 }
//                 if (Rank == "4")
//                 {
//                     return 4;
//                 }
//                 if (Rank == "5")
//                 {
//                     return 5;
//                 }
//                 if (Rank == "6")
//                 {
//                     return 6;
//                 }
//                 if (Rank == "7")
//                 {
//                     return 7;
//                 }
//                 if (Rank == "8")
//                 {
//                     return 8;
//                 }
//                 if (Rank == "9")
//                 {
//                     return 9;
//                 }
//                 // if J, Q, K --> value = 10
//                 if (Rank == "10" || Rank == "Jack" || Rank == "Queen" || Rank == "King")
//                 {
//                     return 10;
//                 }
//                 // if Ace --> value = 11
//                 if (Rank == "Ace")
//                 {
//                     return 11;
//                 }

//                 return 0;
//             }

//             public override string ToString()
//             {
//                 return $"{Rank} of {Suit}";
//             }
//         }

//         // - Deck

//         class Deck
//         {
//             //   - Properties: A list of 52 cards
//             public List<Card> Cards { get; set; } = new List<Card>();

//             public Deck()
//             {
//                 //   - Behavior: Make a new deck of 52 shuffled cards. Deal one card out of the deck.
//                 CreateDeck();
//                 Shuffle();
//             }

//             public void CreateDeck()
//             {
//                 // Algorithm B
//                 // - Make a new list of the fours suits
//                 var suits = new List<string>() { "clubs", "diamonds", "hearts", "spades" };
//                 // - Make of a list of 13 ranks and call this list ranks
//                 var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
//                 // - Make a new list of strings named 'deck'
//                 var deck = new List<string>();
//                 // - Make a loop that goes through all the suits
//                 foreach (var suit in suits)
//                 {
//                     //   Make a loop that goes through all the 'ranks'
//                     //   add newly formed string to the end of the deck list - For Suit = Clubs
//                     foreach (var rank in ranks)
//                     {
//                         var card = new Card()
//                         {
//                             Suit = suit,
//                             Rank = rank
//                         };
//                         Cards.Add(card);
//                     }

//                 }
//                 // Console.WriteLine(Cards);
//             }
//             public void Shuffle()
//             {

//                 var numberOfCards = Cards.Count;
//                 for (var rightIndex = numberOfCards - 1; rightIndex >= 1; rightIndex--)
//                 {
//                     //   leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer"
//                     var randomNumberGenerator = new Random();
//                     var leftIndex = randomNumberGenerator.Next(rightIndex);
//                     // leftIndex = random integer >= 0 and < rightIndex
//                     //   Now swap the values at rightIndex and leftIndex by doing this:
//                     //   leftCard = the value from deck[leftIndex]
//                     var leftCard = Cards[leftIndex];
//                     //   rightCard = the value from deck[rightIndex]
//                     var rightCard = Cards[rightIndex];
//                     //   deck[rightIndex] = leftCard
//                     Cards[rightIndex] = leftCard;
//                     //   deck[leftIndex] = rightCard
//                     Cards[leftIndex] = rightCard;
//                 }
//             }
//         }

//         // - Hand
//         class Hand
//         {
//             //   - Properties: A list of individual Cards
//             public List<Card> CurrentCards { get; set; } = new List<Card>();
//             //   - Behaviors:
//             //     - TotalValue representing he sum of the individual Cards in the list.
//             public int HandValue()
//             {
//                 //       - Start with a total = 0
//                 var sum = 0;
//                 //       - For each card in the hand do this:
//                 //         - Add the amount of that card's value to total
//                 foreach (var card in CurrentCards)
//                 {
//                     sum = sum + card.Value();
//                 }

//                 return sum;
//             }
//         }
//         //       - return "total" as the result
//         //     - Add a card to the hand
//         //       - Adds the supplied card to the list of cards

//         static void Main(string[] args)
//         {
//             var deck = new Deck();
//             // foreach (var card in deck.Cards)
//             // {
//             //     Console.WriteLine($"{card}: {card.Value()}");

//             // }

//             var myHand = new Hand();

//             // Initial Hand
//             myHand.CurrentCards.Add(deck.Cards[0]);
//             myHand.CurrentCards.Add(deck.Cards[1]);
//             // Stand
//             // done --> look at dealer's hand
//             Console.WriteLine(myHand.HandValue());
//             // Console.WriteLine("------------------------");
//             // Console.WriteLine(myHand[0].Value() + myHand[1].Value());


//             // Hit
//             // myHand.Add(deck.Cards[2]);

//         }

//     }


// }