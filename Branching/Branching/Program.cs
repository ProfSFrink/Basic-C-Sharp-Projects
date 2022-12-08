// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 11: Branching Tutorial Video
// AUTHOR: Steven Partlow
// DATE: 08/12/2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Branching Tutorial");
            Console.WriteLine("------------------\n");

            /* IF / ELSE IF / ELSE Statements */

            int currentTemperature = 80; // Declare an integer variable called currentTemperature and assign it the value 70
            int roomTemperature = 70; // Declare an integer variable called roomTemperature and assign it the value 70

            if (currentTemperature == roomTemperature) // IF currentTemperature is EQUAL to roomTemperature THEN
            {
                Console.WriteLine("It is exactly room temperature."); // Print this text to the console window
            } // End IF
            else if (currentTemperature > roomTemperature) // ELSE IF currentTemperature is GREATER THAN roomTemperature THEN
            {
                Console.WriteLine("It is warmer than room temperature."); // Print this text to the console window
            } // End ELSE IF
            else if (roomTemperature > currentTemperature) // ELSE IF roomTemperature is GREATER THAN currentTemperature THEN
            {
                Console.WriteLine("Room temperature is warmer than current temperature."); // Print this text to the console window
            } // End ELSE IF
            else // IF none of the above conditions are TRUE THEN
            {
                Console.WriteLine("It is not exactly room temperature."); // Print this text to the console window
            } // End ELSE

            /* TERNARY Operators */

            // Utilise a ternary operator to check IF currentTemperature and roomTemperature are equal, if they are assign the value on the left - hand side of the colon,
            // if it is not then assign the value to the right - hand side of the semi-colon.
            string comparisonResult = currentTemperature == roomTemperature ? "\nIt is room temp." : "\nIt is not room temp.";

            Console.WriteLine(comparisonResult); // Print the value of comparisonResult to the console window

            /* IF / ELSE IF / ELSE Statements with user input */

            roomTemperature = 70; // Assign this value to the integer variable roomTemperature

            Console.Write("\nHi, what is your name?: "); // Print this text to the console
            string name = Console.ReadLine(); // Assign the user input to the string variable name

            Console.Write("\nHi, " + name + ", what is the temperature where you are?: "); // Concatenate this string and output it to the console window
            currentTemperature = Convert.ToInt32(Console.ReadLine()); // Cast the user input to an integer and assign the value to currentTemperature

            if (currentTemperature == roomTemperature) // IF currentTemperature is EQUAL to roomTemperature THEN
            {
                Console.WriteLine("\nIt is exactly room temperature."); // Print this text to console
            } // End IF
            else if (currentTemperature > roomTemperature) // ELSE IF currentTemperature is GREATER THAN roomTemperature THEN
            {
                Console.WriteLine("\nIt is warmer than room temperature"); // Print this text to console
            } // End ELSE IF
            else if (roomTemperature > currentTemperature) // ELSE IF roomTemperature is GREATER THAN currentTemperature THEN
            {
                Console.WriteLine("\nIt is colder than room temperature"); // Print this text to console
            } // End ELSE IF
            else // IF none of the above conditions are TRUE THEN
            {
                Console.WriteLine("\nUhhhhh... something went wrong."); // Print this text to console
            } // End ELSE

            // TERNARY Operator with user input

            Console.Write("\nWhat is your favortie number?: "); // Print this text to the console
            int favNum = Convert.ToInt32(Console.ReadLine()); // Cast the user input to the integer favNum

            // Through use of the ternary operator check if favNum is equal to 12, if it is assign the value to the left of the semi-colon to result else assign the value to the 
            // right of the semi-colon to result
            string result = favNum == 12 ? "\nYou have an awesome favorite number." : "\nYou do not have an awesome favorite number.";

            Console.WriteLine(result); // Output the value of result to the display

            Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
            Console.ReadLine(); // Pause the application so we can see the output 
        } // End MAIN

    } // End CLASS

} // End NAMESPACE
