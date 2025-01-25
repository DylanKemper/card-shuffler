using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    enum FaceValue
    {
        Ace = 1,    // Enum for card face values
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    enum Suit  // Enum for card suits
    {
        Hearts = 1,
        Spades = 2,
        Diamonds = 3,
        Clubs = 4
    }

    internal class Card
    {
        private FaceValue value;
        private Suit suit;

        public Card(FaceValue val, Suit suit)
        {
            this.value = val;
            this.suit = suit;
        }

        public Card()
        {
            SetCardValue();
            SetCardSuit();
            DisplayCard();
        }

        public void DisplayCard()
        {
            Console.WriteLine($"{this.value} of {this.suit}");
        }

        /// <summary>
        /// Sets the card's face value.
        /// Prompts the user to enter a valid card face value (1-13).
        /// Ensures the input is an integer within the valid range before assigning it.
        /// </summary>
        private void SetCardValue()
        {
            int userVal = 0;
            Console.WriteLine("Enter the card's face value (1-13): ");

            while (true)
            {
                if (IsValidInput(Console.ReadLine(), 1, 13, out userVal)) // Checks that userInput is an integer within the defined range
                {
                    this.value = (FaceValue)userVal;
                    break;
                }
                Console.WriteLine("Invalid input. Try again:");    // Error for invalid input
            }
        }

        /// <summary>
        /// Sets the card's suit value.
        /// Prompts the user to choose a suit (1-4).
        /// Ensures the input is an integer within the valid range before assigning it.
        /// Uses a Suit enum to parse from user integer input to string values.
        /// </summary>
        private void SetCardSuit()
        {
            int userVal = 0;
            Console.WriteLine("Enter the card's suit:\n" +
                "Valid suits:\n" +
                "1 - Hearts\n" +
                "2 - Spades\n" +
                "3 - Diamonds\n" +
                "4 - Brocolli");

            while (true)
            {
                if (IsValidInput(Console.ReadLine(), 1, 4, out userVal))
                {
                    this.suit = (Suit)userVal;
                    break;
                }
                Console.WriteLine("Invalid input. Try again:");
            }
        }

        /// <summary>
        /// Validates whether the input can be parsed to an integer and if it's within the specified range.
        /// </summary>
        /// <param name="input">The string to be validated and converted to an integer.</param>
        /// <param name="min">The minimum allowed value for the parsed integer.</param>
        /// <param name="max">The maximum allowed value for the parsed integer.</param>
        /// <param name="parsedValue">The parsed integer value, if valid.</param>
        /// <returns>True if the input can be parsed and is within the range; otherwise, false.</returns>
        private bool IsValidInput(string input, int min, int max, out int parsedValue)
        {
            return int.TryParse(input, out parsedValue) && parsedValue >= min && parsedValue <= max;
        }
    }
}