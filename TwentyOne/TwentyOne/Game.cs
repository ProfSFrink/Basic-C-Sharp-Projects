// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 3: Inheritance Tutorial
// AUTHOR: Steven Partlow
// DATE: 08/01/2023

// GAMES CLASS DEFINITION

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    /* This generic game class contains properties and methods which are common to all card games, and can be reused later by other card games */

    public class Game
    {
        public List<string> Players { get; set; } // A list of string called Players, with each element representing a player in the game
        public string Name { get; set; } // The name of the game (Blackjack, Poker, Texas Hold-em, Solitaire, etc)
        public string Dealer { get; set; } // The name of our card games dealer
        

        /* This method is simply to take the list of player names and output them to the console, something that again all card games would have in common */

        public void ListPlayers()
        {
            foreach (string player in Players) // Iterate through each element of the list players assigning the value to the string player
            {
                Console.WriteLine(player); // Output the current value assigned to player to the console
            } // End FOREACH
        } // End ListPlayers Method

    } // End GAME Class

} // End TwentyOne Namespace
