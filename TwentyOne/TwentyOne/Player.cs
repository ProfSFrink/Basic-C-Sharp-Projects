// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 5: Abstract Classes Tutorial
// AUTHOR: Steven Partlow
// DATE: 10/01/2023

// PLAYER CLASS DEFINITION

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        /* PROPERTIES  */

        public List<Card> Hand { get; set; } // A list data type containing instances of the Card class, this object will represent the players hand of card in the game
        public int Balance { get; set; } // An integer data type to represent the player's current balance
        public string Name { get; set; } // A string data type to represent the player's name
        public bool IsActivelyPlaying { get; set; } // A boolean data type to track if it's this instance of the player classes turn in during the game
    } // End PLayer CLASS Definition

} // End TwentyOne NAMESPACE
