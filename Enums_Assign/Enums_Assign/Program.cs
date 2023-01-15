// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 6: Enums Assignment
// AUTHOR: Steven Partlow
// DATE: 14/01/2023

// GOALS

// 1) Create an enum for the days of the week. - DONE
// 2) Prompt the user to enter the current day of the week. - DONE
// 3) Assign the value to a variable of that enum data type you just created. - DONE
// 4) Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs. - DONE

using System;
using System.Linq;

namespace Enums_Assign
{

    class Program
    {

        static void Main(string[] args)
        {
            
            // Output all the below text to the console
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Enums Assignment");
            Console.WriteLine("----------------\n");

            // GOAL 4) Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs

            try // Try this block of code
            {
                // GOAL 2) Prompt the user to enter the current day of the week

                Console.Write("Please enter the current day of the week: "); // Output this text to the console
                string userInput = Console.ReadLine(); // Assign the input to the string variable userInput

                if (userInput.All(char.IsDigit)) // Check if the value of userInput is all numbers, if it is
                {
                    Console.WriteLine("\nPlease enter the current day of the week in text format, no numbers, Thank You!"); // Output this text to the console
                    Console.ReadLine(); // Pause the application
                } // End IF

                else // If the value of userInput is text
                {
                    // GOAL 3) Assign the value to a variable of that enum data type you just created

                    /* Create an instance of the DaysOfTheWeek enum called day then utilise the built in method .Parse() to search it for the day the user entered which is stored in the value userInput, the true flag tells the program to ignore the case of the string */

                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput, true);

                    Console.WriteLine("\nThe day of the week you entered is valued: " + day); // Concatenate this string and output to the console
                    Console.ReadLine(); // Pause the application
                } // End ELSE
                
            } // End TRY

            catch // If an exception is raised then execute this block of code
            {
                Console.WriteLine("\nPlease enter an actual day of the week"); // Output this text to the console
                Console.ReadLine(); // Pause the Application
            } // End CATCH

            } // End MAIN

    } // End CLASS

    // GOAL 1) Create an enum for the days of the week
    
    public enum DaysOfTheWeek // Define an enum data type with these values
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    } // End DaysOfTheWeek ENUM

} // End Enums_Assign NAMESPACE
