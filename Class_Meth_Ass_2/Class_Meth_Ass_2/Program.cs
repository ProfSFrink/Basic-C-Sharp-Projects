// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 4: Classes and Methods Assignment 2
// AUTHOR: Steven Partlow
// DATE: 06/01/2023

// GOALS
// 1) Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional. Have the method do a math operation and return an integer result. - DONE
// 2) In the Main() method of the console app, instantiate the class. - DONE
// 3) Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number. - DONE
// 4) Call the method in the class, passing in the one or two numbers entered. - DONE
// 5) Try various combinations of numbers on the code, including having no second number. - DONE

using System;

namespace Class_Meth_Ass_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Classes and Methods Assignment 2");
            Console.WriteLine("--------------------------------");

            Console.Write("Please enter a whole number, thank you: "); // Output this text to the console
            int userNum1 = Convert.ToInt32(Console.ReadLine()); // Cast the user input to an integer and store the value in userNum1

            Console.Write("\nPlease enter a whole number, you can leave this black if you wish (will default to 1 if nothing is entered): "); // Output this text to the console
            string userNum2 = Console.ReadLine(); // Store the user input in userNum2

            if (string.IsNullOrEmpty(userNum2)) // Check if the user entered a second number or not, my way of doing this is to check if the value the user enters is null (empty) or not, if it is empty
            {
                int answer = Class_Meth_Ass_2.mathMethod(userNum1); // We instantiate Class_Meth_Ass_2 class and use our mathMethod method and pass in just the on number the user entered, and then store the returned result in the integer answer
                Console.WriteLine("\n" + userNum1 + "*" + "1" + "*" + "1"+ "=" + +answer); // We concatenate a string showing the equation that will take place along with on the end
            } // End IF
            else // If the user did enter a second
            {
                int answer = Class_Meth_Ass_2.mathMethod(userNum1, Convert.ToInt32(userNum2)); // We instantiate Class_Meth_Ass_2 class and use our mathMethod method and pass in both numbers the user entered, casting userNum2 to an integer as we now know a value was entered and then store the returned result in the integer answer
                Console.WriteLine("\n" + userNum1 + "*" + userNum2 + "*" + userNum2 + "=" + answer); // We concatenate a string showing the equation that will take place along with on the end 
            } // End ELSE

            Console.ReadLine(); // Pause the application

        } // End MAIN

    } // End CLASS

} // End NAMESPACE
