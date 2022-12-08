// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 11: Challenge 11A-1: Ternary Operator
// AUTHOR: Steven Partlow
// DATE: 08/12/2022
//
// GOAL
// 1) Utilise the ternary operator in a C# application - DONE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_11A_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("CHALLENGE 11A-1: Ternary operator");
            Console.WriteLine("---------------------------------\n");

            int gameAge = 16; // This is how old a child must be to play our game, this value is assigned to integer variable gameAge

            Console.Write("How old is your child?: "); // Print this text to the console
            int childAge = Convert.ToInt32(Console.ReadLine()); // Take the user input and cast it to an integer named childAge

            // Check if the value of childAge is greater or equal to gameAge if it is print the text on the left-hand side of the semi-colon and if it's not print the text on the right-hand side of the semi-colon
            string result = childAge >= gameAge ? "\nYour child is old enough to play this game!" : "\nSorry, your child is too young to play this game!";

            Console.WriteLine(result); // Print the value of result to the console
            Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
            Console.ReadLine(); // Pause the application so we can see the output 
        } // End MAIN

    } // End CLASS

} // End NAMESPACE
