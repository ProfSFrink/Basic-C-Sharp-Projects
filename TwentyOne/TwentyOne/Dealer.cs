// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 5: Polymorphism Tutorial
// AUTHOR: Steven Partlow
// DATE: 10/01/2023

// DEALER CLASS DEFINITION

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer
    {
        /* PROPERTIES */

        public string Name { get; set; } // A string data type to represent the dealer's name
        public Deck Deck { get; set; } // A deck data type to represent the dealer's deck of cards
        public int Balance { get; set; } // A integer data type to represent the dealer's balance

        /* METHODS */

        public void Deal(List<Card> Hand) // A method which allows the dealer to add cards to their hand of card, one input parameter which is a list containing elements of the Card Class called Hand 
        {
            /* Utilise the built-in Add() method of the Hand object to add a card to the dealers deck, then use the built-in method First() of the Cards object to take the first element in that list, then print the name of the card added to the console */
            Hand.Add(Deck.Cards.First()); // Utilise the built-in Add() method of the Hand object to add a card to the dealers deck
            Console.WriteLine(Deck.Cards.First().ToString() + "\n"); // Use the built-in method First() of the Cards object to take the first element in that list
            Deck.Cards.RemoveAt(0); // Finally use the built-in method RemoveAt() which will remove the card at index 0 from the Deck object as we have added to the Dealers hand so can remove it from the original deck
        } // End Deal Method

    } // End CLASS definition Dealer

} // End NAMESPACE TwentyOne
