// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 5: Abstract Classes Tutorial
// AUTHOR: Steven Partlow
// DATE: 10/01/2023

// TWENTYONEGAME CLASS DEFINITION

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    /* This TwentyOneGame class is specifically for our TwentyOne (Blackjack) game and will inherit the Game class */
    public class TwentyOneGame : Game // Inherit the Game Class
    {
        /* METHODS */

        public override void Play() // As this is an inherited abstract method from the Game class we need the override keywrod
        {
            throw new NotImplementedException(); // Throw an error inform the user that this method has not been implementated at this time
        } // End Play Method

        public override void ListPlayers() // We are overiding the inherited ListPlayers() method with this instance of the method
        {
            Console.WriteLine("21 Players:"); // Ouput this text to the console
            base.ListPlayers(); // Execute the base version of this method that we are inheriting
        } // End ListPlayers Method

    } // End TwentyOneGame Class

} // EMd TwemtyOne Namespace
