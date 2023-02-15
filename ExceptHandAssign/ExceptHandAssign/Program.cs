// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 8: Exception Handling Assignment
// AUTHOR: Steven Partlow
// DATE: 14/02/2023

// GOALS

// 1) Ask the user for their age. - DONE
// 2) Display the year the user was born. - DONE
// 3) Exceptions must be handled using “try/catch.” - DONE
// 4) Display appropriate error messages if the user enters zero or negative numbers. - DONE
// 5) Display a general message if an exception was caused by anything else. - DONE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptHandAssign
{

    class Program
    {

        static void Main(string[] args)
        {

            // Output all the below text to the console
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Exception Handling Assignment");
            Console.WriteLine("-----------------------------\n");

            bool validInput = false; // Define a boolean variable called validInput and by default set it to false
            int userAge; // Define a integer variable called userAge

            while (!validInput) // While validInput is set to false
            {
                // GOAL 3) Exceptions must be handled using “try/catch.”

                try
                {

                    // GOAL 1) Ask the user for their age

                    Console.Write("Please enter your age: "); // Output this text to the console
                    userAge = Convert.ToInt32(Console.ReadLine()); // Attempt to cast the user input to a integer and store the result in userAge

                    if (userAge < 0) // If the user has entered a negative number
                    {
                        throw new ArgumentOutOfRangeException(); // Throw an ArugumentOutOfRangeException
                    } // End IF

                    else if (userAge == 0) // If the user has entered zero then
                    {
                        throw new ArgumentNullException(); // Throw an ArguementNullException
                    } // End IF

                } // End TRY

                // GOAL 4) Display appropriate error messages if the user enters zero or negative numbers

                catch (ArgumentNullException) // Execute this catch block if the user has entered zero
                {

                    Console.WriteLine("\nPlease do not enter zero. Enter a valid age. Thank You."); // Output this text to the console
                    Console.WriteLine("\nPress ENTER to continue"); // Output this text to the console
                    Console.ReadLine(); // Pause the application here
                    validInput = false; // Set validInput to false
                    continue; // Start the WHILE loop again

                } // End CATCH

                catch (ArgumentOutOfRangeException) // Execute this catch block if the user enters a negative number
                {

                    Console.WriteLine("\nPlease do not enter a negative number. Enter a Valid Age. Thank You."); // Output this text to the console
                    Console.WriteLine("\nPress ENTER to continue"); // Output this text to the console
                    Console.ReadLine(); // Pause the application here
                    validInput = false; // Set validInput to false
                    continue; // Start the WHILE loop again

                } // End CATCH

                catch (FormatException) // Execute this catch block if the user enters letters
                {

                    Console.WriteLine("\nPlease do not enter letters, only numbers. Enter a Valid Age. Thank You."); // Output this text to the console
                    Console.WriteLine("\nPress ENTER to continue"); // Output this text to the console
                    Console.ReadLine(); // Pause the application here
                    validInput = false; // Set validInput to false
                    continue; // Start the WHILE loop again
                } // End CATCH

                // GOAL 5) Display a general message if an exception was caused by anything else

                catch (Exception)
                {

                    Console.WriteLine("\nAn error occurred."); // Output this text to the console
                    Console.WriteLine("\nPress ENTER to continue"); // Output this text to the console
                    Console.ReadLine(); // Set validInput to false
                    continue; // Start the WHILE loop again  

                } // End CATCH

                validInput = true; // Set validInput to true sio we can exit the loop

                // GOAL 2) Display the year the user was born

                Console.WriteLine("\nThe year you were born in is " + (DateTime.Now.Year - userAge)); // Get the current year then deduct the user age from it and output the result to the console
                Console.ReadLine(); // Pause the application here

            } // End WHILE

        } // End MAIN

    } // End CLASS

} // End ExceptHandAssign NAMESPACE
