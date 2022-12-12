// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 12: Challenge 12A-1: Switch Statement
// AUTHOR: Steven Partlow
// DATE: 12/12/2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_12A_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Challenge 12A-1: Switch Statement");
            Console.WriteLine("---------------------------------\n");

            Console.Write("Please enter a number between 1 and 5 to be recommended a game to play: "); // Output this text to the console
            int nextGame = Convert.ToInt32(Console.ReadLine()); // Take the user input and cast from a string to an integer value called nextGame

            // Execute a switch statement on the value nextGame
            switch(nextGame)
            {
                case 1: // If the user has entered the value 1 then run this case
                    Console.WriteLine("\nThe Legend of Heroes: Trials in the Sky - First Chapter (PC STEAM)"); // Output this text to the console
                    break; // Break out of the switch statement and do not check any other case statements
                case 2: // If the user has entered the value 2 then run this case
                    Console.WriteLine("\nTeenage Mutant Ninja Turtles: The Cowabunga Collection (PC STEAM, PS4, XB1, SWITCH)"); // Output this text to the console
                    break; // Break out of the switch statement and do not check any other case statements
                case 3: // If the user has entered the value 3 then run this case
                    Console.WriteLine("\nTactics Ogre Reborn (PC STEAM, SWITCH, PS4)"); // Output this text to the console
                    break; // Break out of the switch statement and do not check any other case statements
                case 4: // If the user has entered the value 4 then run this case
                    Console.WriteLine("\nAtari 50: Anniversary Collection (PC STEAM, PS4, XB1, SWITCH"); // Output this text to the console
                    break; // Break out of the switch statement and do not check any other case statements
                case 5: // If the user has entered the value 5 then run this case
                    Console.WriteLine("\nInto the Breach: Advanced Edition (PC STEAM, PS4, XB1, SWITCH, IOS, ANDROID"); // Output this text to the console
                    break; // Break out of the switch statement and do not check any other case statements
                default: // If the user has not entered any of the above values then run this case
                    Console.WriteLine("\nYou have entered an invalid choice, please try again and enter a number between 1 and 5."); // Output this text to the console
                    break; // Break out of the switch statement and do not check any other case statements
            } // End SWITCH

            Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
            Console.ReadLine(); // Pause the application so we can see the output 

        } // End MAIN

    } // End CLASS

} // End NAMESPACE
