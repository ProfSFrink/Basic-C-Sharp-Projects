// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 7: DateTime Assignment
// AUTHOR: Steven Partlow
// DATE: 24/01/2023

// GOALS

// 1) Prints the current date and time to the console. - DONE
// 2) Asks the user for a number. - DONE
// 3) Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2. - DONE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assign
{

    class Program
    {

        static void Main(string[] args)
        {
            // Output all the below text to the console
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("DateTime Assignment");
            Console.WriteLine("-------------------\n");

            // GOAL 1) Prints the current date and time to the console

            DateTime currentTime = DateTime.Now; // Get the current date and time and assign it the datetime object currentTime
            Console.WriteLine("The current date and time is: " + currentTime); // Get the value of currentTime and concatenate it with this string then output it to the console

            // GOAL 2) Asks the user for a number

            Console.Write("\nPlease enter a number: "); // Output this text to the console window
            int userNum = Convert.ToInt32(Console.ReadLine()); // Cast the user input to an integer called userNum

            // GOAL 3) Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2

            Console.WriteLine("\nThe time in X hours will be: " + currentTime.AddHours(userNum)); // Take the value of currentTime and using the built-in method AddHours add the number entered in by the user to the value of currentTime and then concatenate with this string and output the result to the console

            Console.ReadLine(); // Pause the application
        } // End MAIN

    } // End CLASS

} // End DateTime_Assign NAMESPACE
