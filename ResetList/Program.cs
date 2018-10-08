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

            for (var i = 0; i < turnToPlay; i++)
            {
                PopulateDeck(deck);

                var playerHand = new List<Card>();
                var emptyList = new List<Card>();

                for (var j = 0; j < playerNumber; j++)
                {
                    for (var k = 0; k < numberCardToDraw; k++)
                    {
                        var deckSize = deck.Count;
                        var cardNumberToDraw = random.Next(0, deckSize);
                        var cardToDraw = deck[cardNumberToDraw];

                        playerHand.Add(cardToDraw);
                        deck.Remove(cardToDraw);
                    }

                    DisplayDeck(j, playerHand); // Affiche la main du joueur
                    playerHand = emptyList; // Vide la main du joueur
                }

                Console.WriteLine("Passer au deuxième lancer ?");
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
