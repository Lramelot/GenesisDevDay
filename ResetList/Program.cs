using System;
using System.Collections.Generic;

namespace ResetList
{
    class Program
    {
        static void Main(string[] args)
        {
            const int playerNumber = 4;
            const int numberCardToDraw = 4;
            const int turnToPlay = 2;

            var random = new Random();
            var deck = new List<Card>();

            for (var currentTurn = 0; currentTurn < turnToPlay; currentTurn++)
            {
                PopulateDeck(deck);

                var playerHand = new List<Card>();
                var emptyList = new List<Card>();

                for (var currentPlayertoPlay = 0; currentPlayertoPlay < playerNumber; currentPlayertoPlay++)
                {
                    for (var cardsInHand = 0; cardsInHand < numberCardToDraw; cardsInHand++)
                    {
                        var deckSize = deck.Count;
                        var cardNumberToDraw = random.Next(0, deckSize);
                        var cardToDraw = deck[cardNumberToDraw];

                        playerHand.Add(cardToDraw);
                        deck.Remove(cardToDraw);
                    }

                    DisplayDeck(currentPlayertoPlay, playerHand); // Affiche la main du joueur
                    playerHand = emptyList; // Vide la main du joueur
                }

                if (currentTurn == 0)
                {
                    Console.WriteLine("Passer au deuxième lancer ?");
                }

                Console.ReadKey();
            }
        }

        private static void PopulateDeck(List<Card> deck)
        {
            var colors = new[] { "Pique", "Trefle", "Coeur", "Carreau"};
            var images = new[] {"As", "Valet", "Dame", "Roi", "10"};

            foreach (var color in colors)
            {
                foreach (var image in images)
                {
                    deck.Add(new Card(color, image));
                }
            }
        }

        private static void DisplayDeck(int playerNumber, List<Card> hand)
        {
            Console.WriteLine($"==== Main du joueur numéro {playerNumber + 1} ====");

            foreach (var card in hand)
            {
                Console.WriteLine($"{card.Image} de {card.Color}");
            }
        }

        public class Card
        {
            public string Color { get; set; }
            public string Image { get; set; }

            public Card(string color, string image)
            {
                Color = color;
                Image = image;
            }
        }
    }
}
