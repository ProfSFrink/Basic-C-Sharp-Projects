// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 5: C# Class Concepts
// AUTHOR: Steven Partlow
// DATE: 10/01/2023

// GAMES CLASS DEFINITION

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    /* This generic game class contains properties and methods which are common to all card games, and can be reused later by other card games */

    public abstract class Game // Make the Game class and abstract class as we will never need to create an instance of this class instead only inherit from it
    {
        /* PROPERTIES */

        public List<Player> Players { get; set; } // A list of Player objects called Players, with each element representing a player in the game
        public string Name { get; set; } // The name of the game (Blackjack, Poker, Texas Hold-em, Solitaire, etc
        public Dictionary<Player, int> Bets { get; set; } // A dictionary called Bets to track the bets the players have made the key is an instance of the Player class with value being an integer value to represent the amount bet

        /* This method is simply to take the list of player names and output them to the console, something that again all card games would have in common */

        /* METHODS */

        public abstract void Play(); // Create an abstract method call Play() which will implement in any inheriting class

        public virtual void ListPlayers() // The virtual keyword allows this method to be inherited but also overriden
        {
            foreach (Player player in Players) // Iterate through each element of the list Players assigning the value to the string player
            {
                Console.WriteLine(player.Name); // Output the current value assigned to the player.name property to the console
            } // End FOREACH
        } // End ListPlayers Method

    } // End GAME Class

} // End TwentyOne Namespace
