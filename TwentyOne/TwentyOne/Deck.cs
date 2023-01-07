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
        /* CLASS CONSTRUCTOR */

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

        /* CLASS PROPERTIES */

        public List<Card> Cards { get; set; }

        /* CLASS METHODS */

        public void Shuffle(int times = 1) // A custom method with three parameters a Deck object for the method to shuffle, the second paramter is an output parameter which will specify the number of times the deck was shuffled, then a a final optional parameter which by default is set to one which controls the number of times the deck will be shuffled
        {

            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>(); // Create a new list consisting of Card objects called TempList
                Random random = new Random(); // Create a new instance of the Random object and call it random

                while (this.Cards.Count > 0) // Keep iterating as long as their is at least one card in deck
                {
                    int randomIndex = random.Next(0, this.Cards.Count); // Generate a random integer between 0 and the current number of element left with in the deck list
                    TempList.Add(this.Cards[randomIndex]); // Add the card at the index position randomIndex that is in the deck list and add it to TempList
                    this.Cards.RemoveAt(randomIndex); // Now remove the card at position randomIndex from the list deck
                } // End WHILE

                this.Cards = TempList; // Replace the entire contents of deck with the contents of TempList
            } // End FOR

        } // End Shuffle Method
    } // End CLASS

} // End NAMESPACE
