using System;
using System.Collections.Generic;

namespace BlackJackCS
{
    class Hand
    {
        public List<Card> CurrentCards { get; set; } = new List<Card>();


        public void AddCard(Card cardToAdd)

        {
            CurrentCards.Add(cardToAdd);
        }

        public int TotalValue()
        {
            var total = 0;
            foreach (var card in CurrentCards)
            {

                total = total + card.Value();

            }
            return total;
        }

        public void PrintCardsAndTotal(string handName)

        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write($"{handName}, your cards are: ");
            Console.WriteLine(String.Join(", ", CurrentCards));
            Console.WriteLine();
            Console.WriteLine($"The total value of your hand is: {TotalValue()}");
            Console.WriteLine();


        }

    }

    class Card
    {
        public string Face { get; set; }
        public string Suit { get; set; }

        override public string ToString()
        {
            return $"the {Face} of {Suit}";
        }

        public int Value()
        {
            switch (Face)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                    return int.Parse(Face);

                case "Jack":
                case "Queen":
                case "King":
                    return 10;

                case "Ace":
                    return 11;

                default:
                    return 0;
            }
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

            var player = new Hand();
            var dealer = new Hand();

            for (var numberOfCardsToDeal = 0; numberOfCardsToDeal < 2; numberOfCardsToDeal++)
            {
                var card = deck[0];
                deck.Remove(card);
                player.AddCard(card);
            }

            for (var numberOfCardsToDeal = 0; numberOfCardsToDeal < 2; numberOfCardsToDeal++)
            {
                var card = deck[0];
                deck.Remove(card);
                dealer.AddCard(card);
            }

            var answer = "";

            while (player.TotalValue() < 21 && answer != "STAND")
            {
                player.PrintCardsAndTotal("Player");

                Console.Write("Do you want to HIT or STAND? ");
                answer = Console.ReadLine().ToUpper();
                Console.WriteLine();
                Console.WriteLine();

                if (answer == "HIT")
                {
                    var newCard = deck[0];
                    deck.Remove(newCard);
                    player.AddCard(newCard);
                }

            }

            player.PrintCardsAndTotal("Player");

            while (player.TotalValue() <= 21 && dealer.TotalValue() <= 17)
            {


                var newCard = deck[0];
                deck.Remove(newCard);

                dealer.AddCard(newCard);
            }

            dealer.PrintCardsAndTotal("Dealer");

            if (player.TotalValue() > 21)
            {
                Console.WriteLine("The DEALER wins!");
            }
            else
            if (dealer.TotalValue() > 21)
            {
                Console.WriteLine("YOU win!");
            }
            else
            if (dealer.TotalValue() > player.TotalValue())
            {
                Console.WriteLine("The DEALER takes it!");
            }
            else
            if (player.TotalValue() > dealer.TotalValue())
            {
                Console.WriteLine("YOU've won!");
            }
            else
            {
                Console.WriteLine("The DEALER has won.");
            }




        }
    }
}