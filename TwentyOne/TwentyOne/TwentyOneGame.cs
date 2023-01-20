// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 7: Creating a Game of Blackjack and Intermediate C# Programming
// AUTHOR: Steven Partlow
// DATE: 18/01/2023

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
        /* CLASS PROPERTIES */

        public TwentyOneDealer Dealer { get; set; }

        /* CLASS METHODS */

        public override void Play() // As this is an inherited abstract method from the Game class we need the override keywrod
        {
            /* -------------- SETUP FOR A NEW GAME -------------- */

            Dealer = new TwentyOneDealer(); // Instantiate a new instance of TwentyOneDealer called Dealer
            foreach (Player player in Players) // Iterate through the list of Players and assign each instance to the player variable
            {
                player.Hand = new List<Card>(); // Creates a new empty hand of playing cards for the Player
                player.Stay = false; // Reset the Stay property to false of the current player object
            } // End FOREACH
            Dealer.Hand = new List<Card>(); // Create a new empty hand of playing cards for the Dealer
            Dealer.Stay = false; // Set the Dealer's stay property to false
            Dealer.Deck = new Deck(); // Issue the Dealer with a new deck of playing cards

            /* -------------- PLACE BETS -------------- */

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

            /* -------------- DEAL CARDS -------------- */

            /* -------------- PLAYER DEAL ------------- */

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing..."); // Output this text to the console
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand); // The dealer deals a card from their deck and deals it to the current instance of Player 
                    if (i == 1) // We check if i is equal to one here as this means we are on the second iteration of the loop which means there is at least two cards in the players hand which means they could have a blackjack at this point
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand); // Define a boolean variable called blackJack then execute the CheckForBlackJack method within the TwentyOneRules class then store the boolean return by the method in the blackJack variable
                        if (blackJack) // If blackJack is true then the player won the current hand
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]); // Concatenate the players name and current bet to this string and then output it to the console
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]); // Add the value of the current player bet plus fifty percent and the value of the original bet to the players balance
                            return; // Exit the method
                        } // End IF
                    } // End IF
                } // End FOREACH


            /* -------------- DEALER DEAL ------------- */

                Console.Write("Dealer: "); // Output this text to the console
                Dealer.Deal(Dealer.Hand); // Deal a card from the dealers deck of playing cards to the dealers hand
                if (i == 1) // We check if i is equal to one here as this means we are on the second iteration of the loop which means there is at least two cards in the dealers hand which means they could have a blackjack at this point
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack) // If blackJack is true then the dealer won the current hand
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!"); // Output this text to the console
                        foreach (KeyValuePair<Player, int> entry in Bets) // Iterate through the Bets dictionary
                        {
                            Dealer.Balance += entry.Value; // Add the value of each bet in the dictionary to the Dealer's balance
                        } // End FOREACH
                    } // End IF
                } // End IF
            } // End FOR

            /* ASK EACH PLAYER IF THEY WANT TO HIT OR STAY */

            foreach (Player player in Players) // Iterate through the Players list and assign each instance to the player value
            {

                while (!player.Stay) // While the current instance of player's stay property is equal to false
                {

                    Console.WriteLine("Your cards are: "); // Output this text to the console
                    foreach (Card card in player.Hand) // Iterate through the current Players Hand and assign the current Card to card
                    {
                        Console.Write("{0} ", card.ToString()); // Call the toString() method attach to the current card which will display the cards face and suit
                    } // End FOREACH
                    Console.WriteLine("\n\nHit or stay?"); // Go down two lines and then output this text to the console
                    string answer = Console.ReadLine().ToLower(); // Take the user input assign it to the string answer and also convert it to lowercase

                    /* ------------ PLAYER STAYS ------------ */

                    if (answer == "stay") // If the value of answer is equal to stay
                    {
                        player.Stay = true; // Set the current players Stay property to true
                        break; // Break the current iteration of the while loop and check if we meet the condition to execute the loop again
                    } // End IF
                    
                    /* ------------ PLAYER HITS ------------- */
                    
                    else if (answer == "hit") // If the value of answer is equal to hit
                    {
                        Dealer.Deal(player.Hand); // Add another card from the dealers deck to the players current hand
                    } // End ELSE IF


                    /* ------------ PLAYER BUSTED ---------- */

                    bool busted = TwentyOneRules.IsBusted(player.Hand); // Utilise the TwentyOneRules.IsBusted() Method and pass in the current players hand and store the returned boolean into the boolean variable busted
                    if (busted) // If the hand is busted then
                    {
                        Dealer.Balance += Bets[player]; // Then the value of the current players bet to the dealer
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance); // Concatenate the current players name, bet value and balance to this string of text and output it to the console

                        /* ------------ ASK THE PLAYER IF WANT TO KEEP PLAYING ------------ */

                        Console.WriteLine("Do you want to play again "); // Output this text to the console
                        answer = Console.ReadLine().ToLower(); // Take the user input assign it to the variable answer and convert it to lowercase
                        if (answer == "yes" || answer == "yeah" || answer == "y") // If the value of answer equates to a variation of yes then
                        {
                            player.IsActivelyPlaying = true; // Set the current players isActivelyPlaying property to true
                        } // End IF
                        else // Then answer does not equate to a variation of yes
                        {
                            player.IsActivelyPlaying = false; // Set the current players isActivelyPlaying property to false
                        } // End ELSE
                    } // End IF

                } // End WHILE

            } // End FOREACH

            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); // Pass the current Dealers hand into the isBusted() method then take the retruned boolean value and assign it to the Dealers isBusted property
            Dealer.Stay = TwentyOneRules

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
