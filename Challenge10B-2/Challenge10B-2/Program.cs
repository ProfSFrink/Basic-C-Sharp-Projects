// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 10: Challenge 10B-2: GREATER THAN / LESS THAN or EQUALS to operator
// AUTHOR: Steven Partlow
// DATE: 06/12/2022
//
// GOAL
// 1) Utilise the greater than operator and display the output to the console - DONE
// 2) Utilise the less than or equal to operator and display the outpu to the console - DONE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge10B_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("CHALLENGE 10B-2: GREATER THAN / LESS THAN or EQUALS to operator");
            Console.WriteLine("---------------------------------------------------------------\n");

            Console.Write("Please enter you age: "); // Print this text to the console
            int userAge = Convert.ToInt32(Console.ReadLine()); // Convert the input to an integer and then assign the entered value to the variable userAge

            if (userAge > 17) // If the userAge variable is 18 or higher then execute the following code:
            {
                // Output all the below text to the display
                Console.WriteLine("\nCongratulations, You are old enough to drink,");
                Console.WriteLine("and smoke,");
                Console.WriteLine("and play the lottery!");

                Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
                Console.ReadLine(); // Pause the application so we can see the output 
            } // End IF
            else if (userAge <= 17) // If the userAge variable is equal to 17 or less then execute the following code:
            {
                // Output all the below text to the display
                Console.WriteLine("\nWe're sorry, but you are not old enough to drink,");
                Console.WriteLine("or smoke,");
                Console.WriteLine("or play the lottery!");

                Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
            Console.ReadLine(); // Pause the application so we can see the output 
            } // End ELSE IF
        } // End MAIN

    } // End CLASS

} // End NAMESPACE
