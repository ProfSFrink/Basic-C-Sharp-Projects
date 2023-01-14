// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 6: Debugging and Value Tests
// AUTHOR: Steven Partlow
// DATE: 12/01/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck(); // Instanstiate a new instance of the Deck object called deck
            deck.Shuffle(3); // Execute the Shuffle method attached to the instance of our Deck class called deck, shuffle the deck three times

            foreach (Card card in deck.Cards) // For each card object in the object Deck property Cards
            {
                Console.WriteLine(card.Face + " of " + card.Suit); // Concatenate the current card Face and Suit properties and output to the console
            } // End FOREACH

            Console.WriteLine(deck.Cards.Count); // Count the number of elements in the Cards property of the deck object
            Console.ReadLine(); // Pause the application

        } // End MAIN

    } // End CLASS

} // End NAMESPACE
