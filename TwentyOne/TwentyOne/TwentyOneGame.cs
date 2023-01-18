// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 5: C# Class Concepts
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

    public class TwentyOneGame : Game, IWalkAway // Inherit the Game Class and the IWalkAway interface
    {
        /* PROPERTIES */

        public TwentyOneDealer Dealer { get; set; }
        /* METHODS */

        public override void Play() // As this is an inherited abstract method from the Game class we need the override keywrod
        {
            /* Setup for a new game */
            Dealer = new TwentyOneDealer(); // Instantiate a new instance of TwentyOneDealer called Dealer
            foreach (Player player in Players) // Iterate through the list of Players and assign each instance to the player variable
            {
                player.Hand = new List<Card>(); // Creates a new empty hand of playing cards for the Player
                player.Stay = false; // Reset the Stay property to false of the current player object
            } // End FOREACH
            Dealer.Hand = new List<Card>(); // Create a new empty hand of playing cards for the Dealer
            Dealer.Stay = false; // Set the Dealer's stay property to false
            Dealer.Deck = new Deck(); // Issue the Dealer with a new deck of playing cards

            /* PLACE BETS */

            Console.WriteLine("Place your bet:"); // Output this text to the console

            foreach(Player player in Players) // Iterate through the list of Players and assign each instance to the player 
            {
                int bet = Convert.ToInt32(Console.ReadLine()); // Cast the value the user enters as a bet and assign it to the integer bet
                bool successfullyBet = player.Bet(bet); // Attempt to place the bet and store if it was successful in the boolean variable successfullyBet
                if (!successfullyBet) // If the attempt to place the Players bet is unsucessful
                {
                    return; // Exit the Play() method
                } // End IF
                Bets[player] = bet; // Because the bet has been placed successfully we add the bet amount to the player bet property which is a dictionary

            } // End FOREACH

            /* DEAL CARDS */
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing..."); // Output this text to the console
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand); // The dealer deals a card from their deck and deals it to the current instance of Player 
                    if (i == 1)
                    {

                    } // End IF
                } // End FOREACH
            } // End FOR

        } // End Play Method

        public override void ListPlayers() // We are overiding the inherited ListPlayers() method with this instance of the method
        {
            Console.WriteLine("21 Players:"); // Ouput this text to the console
            base.ListPlayers(); // Execute the base version of this method that we are inheriting
        } // End ListPlayers Method

        public void WalkAway(Player player) // This is an inherited method from the interface IWalkAWay which we have to implement here as we are inheriting it
        {
            throw new NotImplementedException(); // Throw an error inform the user that this method has not been implementated at this time
        } // End WalkAway Method

    } // End TwentyOneGame Class

} // EMd TwemtyOne Namespace
