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
    public class Card // Define an object called Class and make it public so other programs can use it.
    {
        /* CLASS CONSTRUCTOR */
        public Card()
        {
            Suit = "Spades"; // Assign the property Suit the value "Spades" upon the creation of the card object
            Face = "Two"; // Assign the property Face the value "Two" upon the creation of the card object
        } // End CONSTRUCTOR

        /* PROPERTIES */

        public Suit Suit { get; set; } // A Suit value to represent the Suit property of a playing card
        public string Face { get; set; } // A String value to represent the Face property of a playing card
    } // End Card CLASS Definition

    public enum Suit // Declare an enum called Suit with the following four values 
    { 
        Clubs,
        Diamonds,
        Hearts,
        Spades
    } // End ENUM Suit

} // End TwentyOneNAMESPACE
