// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 10: Challenge 10A-1: IF / ELSE / ELSE IF Statements
// AUTHOR: Steven Partlow
// DATE: 06/12/2022
//
// GOAL
// 1) Write and execute C# code that utilises IF / ELSE and ELSE IF Statements and display the output to the console - DONE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge10A_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("CHALLENGE 10A-1: IF / ELSE / ELSE IF Statements");
            Console.WriteLine("-----------------------------------------------\n");

            Console.Write("Please enter the name of a games console you own: "); // Display this text to the console
            string userPlatform = Console.ReadLine().ToUpper(); // Accept input from the user, assign it to string variable userPlatform and covert it to uppercase

            if (userPlatform == "SWITCH") // If the user platform equals SWITCH execute this IF statement
            {
                Console.WriteLine("\nThe next game you shoud play is: ATARI 50: The Anniversary Collection"); // Print this text to the console

                Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
                Console.ReadLine(); // Pause the application so we can see the output // End IF
            }
            else if (userPlatform == "PC") // If the user platform equals PC execute this IF statement
            {
                Console.WriteLine("\nThe next game you should play is: Vampire Survivors"); // Output this text to the display

                Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
                Console.ReadLine(); // Pause the application so we can see the output // End IF
            } // End ELSE IF
            else if (userPlatform == "PLAYSTATION 5") // If the user platform equals PLAYSTATION 5 execute this IF statement
            {
                Console.WriteLine("\nThe next game you should play is: Star Ocean: The Divine Force"); // Output this text to the console

                Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
                Console.ReadLine(); // Pause the application so we can see the output // End IF
            } // End ELSE IF
            else // If the user input does not equal any of the above statements then execute this ELSE statememnt
            {
                Console.WriteLine("\nYou did not enter a valid platform choice, please rerun the application and try again!");

                Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
                Console.ReadLine(); // Pause the application so we can see the output // End IF
            } // End ELSE

        } // End MAIN

    } // End CLASS
    
} // End NAMESPACE
