// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 12: Loops Assignment
// AUTHOR: Steven Partlow
// DATE: 13/12/2022
//
// GOALS
// 1) Do a boolean comparison using a "while" statement - DONE
// 2) Do a boolean comparison using a "do while" statment

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Loops Assignment");
            Console.WriteLine("----------------\n");

            // GOAL 1) Do a boolean comparison using a "while" statement

            Console.WriteLine("WHILE LOOP Exercise"); // Output this text to the console
            Console.WriteLine("-------------------"); // Output this text to the console

            Console.Write("\nHow old to you think the customer is?: "); // Output this text to the console
            int customerAge = Convert.ToInt32(Console.ReadLine()); // Cast the user input from a string and store the value into the integer customerAge

            bool oldEnoughForAgeRestricted = customerAge >= 18; // Set the bool data type oldEnoughForAgeRestricted to true if customerAge is greater or equal to 18 else set it to false

            while (oldEnoughForAgeRestricted == false) // As long as oldEnoughForAgeRestricted is set to flase execute the following code
            {
                Console.WriteLine("\nThe customer is UNDER AGE and CANNOT be served any age restricted products!. Record the refusal in the refusal register and proceed with the next transaction."); // Print this text to the console window

                Console.Write("\nHow old to you think the customer is?: "); // Output this text to the console
                customerAge = Convert.ToInt32(Console.ReadLine()); // Cast the user input from a string and store the value into the integer customerAge
                oldEnoughForAgeRestricted = customerAge >= 18;
            } // End WHILE

            Console.WriteLine("\nThe customer is old enough to purchase an age restricted product, please proceed with the transacation."); // Print this text to the console window

            // GOAL 2) Do a boolean comparison using a "do while" statment

            Console.WriteLine("\nDO WHILE LOOP Exercise"); // Output this text to the console
            Console.WriteLine("-------------------"); // Output this text to the console

            int userGuess = 0; // Create the integer userGuess and set the value to 0
            bool guessCorrect = userGuess >= 33 && userGuess <= 53;

            do
            {

                Console.WriteLine("\nYou have to guess a number between 1 and 100. The program will only end if the number is within a certain range."); // Output this text to the display
                Console.Write("\nPlease enter a number between 1 and 100: "); // Output this text to the display
                userGuess = Convert.ToInt32(Console.ReadLine()); // Cast the user input from a string and store the value into the integer userGuess

                if (userGuess >= 33 && userGuess <= 53) // If the value of userGuess is greater than 33 and less than 53 then
                {
                    guessCorrect = true; // Set guess correct to true
                    Console.WriteLine("\nYou have guessed correctly, the program will now end!."); // Output this text to the display
                } // End IF

                else // If value of userGuess is outside the above range then inform the user the program will keep running until they guess correctly
                {
                    Console.WriteLine("\nYou have not guessed a number within the correct range, please try again!."); // Output this text to the display
                } // End ELSE

            } // End DO

            while (!guessCorrect); // If guessCorrect is not true execute the WHILE loop again

            Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
            Console.ReadLine(); // Pause the application so we can see the output 
        } // End MAIN

    } // End CLASS

} // End NAMESPACE
