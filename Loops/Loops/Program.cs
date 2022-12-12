// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 12: Loops Tutorial
// AUTHOR: Steven Partlow
// DATE: 12/12/2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess a number?: "); // Output this text to the console
            int number = Convert.ToInt32(Console.ReadLine()); // Take the user input and cast to the integer number
            bool isGuessed = number == 12; // A boolean variable that tracks if a user has successfully guessed the number, we set this to true if the user enters the number 12 or we set it to false if the user entered any other value

            do // We make use of the DO WHILE loop so we can ensure that the WHILE executes at least once
            {
                switch (number)
                {
                    case 62: // If the user entered 62 execute this case
                        Console.WriteLine("You guessed 62. Try again."); // Output this text to the console
                        Console.Write("\nGuess a number?: "); // Output this text to the console
                        number = Convert.ToInt32(Console.ReadLine()); // Take the user input and cast to the integer number
                        break; // End the switch statement here

                    case 29: // If the user entered 29 execute this case
                        Console.WriteLine("You guessed 29. Try again."); // Output this text to the console
                        Console.Write("\nGuess a number?: "); // Output this text to the console
                        number = Convert.ToInt32(Console.ReadLine()); // Take the user input and cast to the integer number
                        break; // End the switch statement here

                    case 55: // If the user entered 55 execute this case
                        Console.WriteLine("You guessed 55. Try again."); // Output this text to the console
                        Console.Write("\nGuess a number?: "); // Output this text to the console
                        number = Convert.ToInt32(Console.ReadLine()); // Take the user input and cast to the integer number
                        break; // End the switch statement here

                    case 12: // If the user entered 12 execute this case
                        Console.WriteLine("You guessed the number 12. That is correct."); // Output this text to the console
                        isGuessed = true; // As the user as guessed the number we set isGuessed to true
                        break; // End the switch statement here

                    default: // If the usder entered none of the above then execute this case
                        Console.WriteLine("You are wrong."); // Output this text to the console
                        Console.Write("\nGuess a number?: "); // Output this text to the console
                        number = Convert.ToInt32(Console.ReadLine()); // Take the user input and cast to the integer number
                        break;

                } // End SWITCH
            } // End DO
            while (!isGuessed); // While isGuessed is not true execute the WHILE loop again

            Console.Read(); // Pause the application here until the user presses the ENTER key

        } // End MAIN

    } // End CLASS

} // End NAMESPACE
