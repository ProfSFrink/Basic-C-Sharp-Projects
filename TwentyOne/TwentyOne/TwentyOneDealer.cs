// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 7: Creating a Game of Blackjack and Intermediate C# Programming
// AUTHOR: Steven Partlow
// DATE: 18/01/2023

// TWENTY ONE DEALER DEFINITION

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{

    public class TwentyOneDealer : Dealer // Inherit the Dealer class
    {
        /* PROPERTIES */

        public List<Card> Hand { get; set; } // A list of card objects to represent the Players hand
        public bool Stay { get; set; } // A boolean variable to represent if the dealer wants to stay
        public bool isBusted { get; set; } // A boolean variable to represent if the dealer has gone bust

    } // End TwentyOneDealer CLASS

} // End TwentyOne NAMESPACE
