// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 8: Libraries and Additional C# Features
// AUTHOR: Steven Partlow
// DATE: 14/02/2023

/* The main program of our application */

using System; // Main system library
using Casino; // Casino class contains all our base classes for our TwentyOne Application
using Casino.TwentyOne; // Casino.TwentyOne contains our main classes and logic for our TwentyOne game
using System.IO; // Use the IO namespace so we can utilise file-handling

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino"; // A constant to define the name of our casino
            Console.Write("Welcome to the {0}. Let's start by telling me your name? ", casinoName); // Concatenate the const casino name with this strinng and output this text to the console
            string playerName = Console.ReadLine(); // Assign the user input to the string variable playerName

            bool validAnswer = false; // Define a boolean variable called validAnswer and set it's default value to false
            int bank = 0; // Define an integer variable called bank and set it's default value to zero
            while (!validAnswer) // Keep the loop going as long as validAnswer is false
            {
                Console.WriteLine("And how much did you bring today?"); // Output this text to the console
                validAnswer = int.TryParse(Console.ReadLine(), out bank); // Attempt to cast the user input to an integer, then set validAnswer to true or false depending if it is successful, if the cast does succeded store the output in bank
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals."); // Output this text to the console
            } // End WHILE
            
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName); // Utilise string formatting to concatenate this string and output it to the console
            string answer = Console.ReadLine().ToLower(); // Assign the user input to the string variable answer and convert it to lowercase

            // If answer equals any of the below listed values
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya") 
            {
                /* Instantiate a new instance of the Player class called player, passing in the player and bank values */
                Player player = new Player(playerName,bank);
                player.Id = Guid.NewGuid(); // Assign the Guid Id property of the new instance of the player class a unique identifier
                using (StreamWriter file = new StreamWriter(@"C:\Users\Pitma\sp\Logs\Logs.txt", true))
                //using (StreamWriter file = new StreamWriter(@"C:\Users\Steven Partlow\Logs.txt", true)) // Create a new StreamWriter object called file assign it the file in the provided path and set that we wish to append to the file to true, the using statement frees up memory after we are done
                {
                    file.WriteLine(player.Id); // Write the value the guid player property to file
                } // End STEAMWRTIER
                Game game = new TwentyOneGame(); // Instantiate a new instance of the TwentyOneGame class but utilise polymorphism to convert it back to the inherited class Game so we can make use of our overloaded operators
                game += player; // Add the new created instance of the Player class player to our new instance of the Game class, this make use of our overloaded "+" operator
                player.IsActivelyPlaying = true; // As the player wants to play the game we set this boolean to true

                /* While player.IsActivelyPlaying equals true and their balance is greater than zero */
                while (player.IsActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play(); // Execute the Play() method of the game object
                    } // End Try

                    catch (FraudException) // This code runs if an ArgumentException is thrown
                    {
                        Console.WriteLine("Security! Kick this person out."); // Output this text to the console
                        Console.ReadLine(); // Pause the application at this point
                        return; // End the application
                    } // End CATCH

                    catch (Exception) // This code runs if a general Exception occurs
                    {
                        Console.WriteLine("An error occurred. Please contact your System Administrator."); // Output this text to the console
                        Console.ReadLine(); // Pause the application at this point
                        return; // End the application
                    } // End CATCH
                } // End WHILE

                game -= player; // Remove the player from the game object
                Console.WriteLine("Thank you for playing"); // Output this text to the console
            } // End IF

            Console.WriteLine("Feel free to look around the casino. Bye for now."); // Output this text to the console
            Console.Read(); // Pause the application
        } // End MAIN

    } // End CLASS

} // End NAMESPACE
