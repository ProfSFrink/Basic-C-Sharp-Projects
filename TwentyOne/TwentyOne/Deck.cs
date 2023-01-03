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
            Cards = new List<Card>();
            Card cardOne = new Card();
            cardOne.Face = "Two";
            cardOne.Suit = "Hearts";
            Cards.Add(cardOne);

        } // End of CONSTRUCTOR
        public List<Card> Cards { get; set; }
    } // End CLASS

} // End NAMESPACE
