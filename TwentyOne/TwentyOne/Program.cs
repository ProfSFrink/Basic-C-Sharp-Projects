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
            deck.Cards = new List<Card>(); // Then take the cards property from the deck object and create a new list of Card objects

            Card cardOne = new Card();
            cardOne.Face = "Queen"; // Assign the Face property of the card object cardOne the value Queen
            cardOne.Suit = "Spades"; // Assign the Suit property of the card object cardOne the value Spades

            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit); // Concatente a the face and suit properties of the cardOne object and output to the console

            Console.ReadLine(); // Pause the application
        } // End MAIN

    } // End CLASS

} // End NAMESPACE
