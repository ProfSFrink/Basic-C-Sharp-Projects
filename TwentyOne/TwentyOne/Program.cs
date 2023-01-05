// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 3: Classes and Objects Tutorial
// AUTHOR: Steven Partlow
// DATE: 03/01/2023

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
            //deck = Shuffle(deck); // Run the method Shuffle, pass in the current version of deck and then replace deck with the new version that the Shuffle method returns
            deck = Shuffle(deck, 3);

            foreach (Card card in deck.Cards) // For each card object in the object Deck property Cards
            {
                Console.WriteLine(card.Face + " of " + card.Suit); // Concatenate the current card Face and Suit properties and output to the console
            } // End FOREACH

            Console.WriteLine(deck.Cards.Count); // Count the number of elements in the Cards property of the deck object
            Console.ReadLine(); // Pause the application

        } // End MAIN

        public static Deck Shuffle(Deck deck) // A custom method with one parameter a Deck object
        {
            List<Card> TempList = new List<Card>(); // Create a new list consisting of Card objects called TempList
            Random random = new Random(); // Create a new instance of the Random object and call it random

            while (deck.Cards.Count > 0) // Keep iterating as long as their is at least one card in deck
            {
                int randomIndex = random.Next(0, deck.Cards.Count); // Generate a random integer between 0 and the current number of element left with in the deck list
                TempList.Add(deck.Cards[randomIndex]); // Add the card at the index position randomIndex that is in the deck list and add it to TempList
                deck.Cards.RemoveAt(randomIndex); // Now remove the card at position randomIndex from the list deck
            } // End WHILE

            deck.Cards = TempList; // Replace the entire contents of deck with the contents of TempList
            return deck; // Return the deck object
        } // End Shuffle Method

        public static Deck Shuffle(Deck deck, int times) // A custom method with two parameters a Deck object, and an integer to determine the number of times we want to shuffle our deck
        {
            for(int i = 0; i < times; i++) // We loop the number of times we want to shuffle our deck
            {
                deck = Shuffle(deck); // Take the instance of deck passed into the method and pass it into the shuffle method and replace deck with the returned result
            } // End FOR
            return deck; // Return the current instance of deck to the main program
        } // End Shuffle Method

    } // End CLASS

} // End NAMESPACE
