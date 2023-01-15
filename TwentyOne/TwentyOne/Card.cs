// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 6: Enumss Tutorial
// AUTHOR: Steven Partlow
// DATE: 14/01/2023

// CARD CLASS DEFINITION

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public struct Card // Define an Struct object called Card and make it public so other programs can use it.
    {
        /* PROPERTIES */

        public Suit Suit { get; set; } // A Suit value to represent the Suit property of a playing card
        public Face Face { get; set; } // A Face value to represent the Face property of a playing card
    } // End Card CLASS Definition

    public enum Suit // Declare an enum called Suit with the following four values 
    { 
        Clubs,
        Diamonds,
        Hearts,
        Spades
    } // End ENUM Suit

    public enum Face // Declare an enum called Face with the following thirteen values
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    } // End ENUM Face

} // End TwentyOneNAMESPACE
