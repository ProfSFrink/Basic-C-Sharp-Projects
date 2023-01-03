// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 3: Classes and Objects Tutorial
// AUTHOR: Steven Partlow
// DATE: 03/01/2023

// DECK CLASS DEFINITION

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>(); // Create a empty list of cards for our deck object
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" }; // Create a list called Suits and assign it these string values, one for each suit of cards
            List<string> Faces = new List<string>() // Create a list called Faces and assign it these string values, one for each face of a card
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces) // Iterate through each value in the list Faces assign it to face
            {
                foreach (string suit in Suits) // Iterate through each value in the list Suits assign it to suit
                {
                    Card card = new Card(); // Instanstiate a new instance of the Card object called card
                    card.Suit = suit; // Assign the current value of suit to our new card objects Suit property
                    card.Face = face; // Assign the current value of face to our new card objects Face property
                    Cards.Add(card); // Add the Card object named card to the Deck object
                } // End FOREACH

            } // End FOREACH

        } // End of CONSTRUCTOR
        public List<Card> Cards { get; set; }
    } // End CLASS

} // End NAMESPACE
