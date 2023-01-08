// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 3: Inheritance Tutorial
// AUTHOR: Steven Partlow
// DATE: 08/01/2023

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
        public void Play()
        {
            throw new NotImplementedException(); // Throw an error inform the user that this method has not been implementated at this time
        } // End Play Method
        
    } // End TwentyOneGame Class

} // EMd TwemtyOne Namespace
