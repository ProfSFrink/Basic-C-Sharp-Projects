// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 11: Price-Quote Assignment
// AUTHOR: Steven Partlow
// DATE: 10/12/2022
//
// GOALS
// 1) The first line of the program must be: "Welcome to Package Express. Please follow the instructions below." - DONE
// 2) The user must then be prompted for the package weight. - DONE
// 3) If the weight is greater than 50, display the error message: "Package too heavy to be shipped via Package Express. Have a good day." At this point, the program must end. - DONE
// 4) The user must be prompted for the package width, height and length. - DONE
// 5) If the total dimensions of the package is greater than 50, display the error message: "Package too big to be shipped via Package Express." At this point, the program will end.
// 6) Next, multiply the three dimensions (height, width, and length) together and multiply the product by the weight. Finally, divide the outcome by 100.
// 7) The result of this calculation is the price quote.
// 8) Display the quote to the user as an amount in pounds sterling.
// 9) Thank the user for using the application and end the program.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Quote_App_Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            // GOAL 1) The first line of the program must be: "Welcome to Package Express." Please follow the instructions below."

            Console.WriteLine("Welcome to Package Express."); // Print this text to the console

            Console.WriteLine("\nPlease follow the instructions below."); // Print this text to the console
            Console.WriteLine("-------------------------------------"); // Print this text to the console

            // GOAL 2) The user must then be prompted for the package weight.

            Console.Write("Please enter the weight of your package in kilos: "); // Print this text to the console
            decimal packageWeight = Convert.ToDecimal(Console.ReadLine()); // Ask the user for the package weight and cast it to a decimal data type called packageWeight

            // GOAL 3) If the weight is greater than 50, display the error message: "Package too heavy to be shipped via Package Express. Have a good day." At this point, the program must end

            if (packageWeight > 50) // If packageWeight is greater than 50 execute inform the user the package is too heavy to be shipped and end the program
            {
                Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Have a good day."); // Print this text to the console
                Console.ReadLine(); // Pause the application so we can view the output
            } // End IF

            else // If the package is less than 50 kilos then we execute the rest of the program
            {
                // GOAL 4) The user must be prompted for the package width, height and length

                Console.Write("\nWhat is the width of your package in centimeters: "); // Print this text to the console
                decimal packageWidth = Convert.ToDecimal(Console.ReadLine()); // Ask the user for the package width and cast it to a decimal data type called packageWidth

                Console.Write("\nWhat is the height of your package in centimeters: "); // Print this text to the console
                decimal packageHeight = Convert.ToDecimal(Console.ReadLine()); // Ask the user for the package height and cast it to a decimal data type called packageHeight

                Console.Write("\nWhat is the length of your packagein centimeters: "); // Print this text to the console
                decimal packageLength = Convert.ToDecimal(Console.ReadLine()); // Ask the user for the package length and cast it to a decimal data type called packageLength

                Console.WriteLine("\nPackage Width: " + packageWidth + "cm"); // Concatenate packageWidth into this string and then display to the console window
                Console.WriteLine("Package Height: " + packageHeight + "cm"); // Concatenate packageHeight into this string and then display to the console window
                Console.WriteLine("Package Length: " + packageLength + "cm"); // Concatenate packageLength into this string and then display to the console window


                // GOAL 5) If the total dimensions of the package is greater than 50, display the error message: "Package too big to be shipped via Package Express." At this point, the program must end

                decimal packageDimensions = packageWidth + packageHeight + packageLength; // Calculate the total dimensions of the package store the result in packageDimension

                Console.WriteLine("\nTotal Package Dimensions: " + (packageDimensions) + "cm"); // Concatenate packageDimensions into this string and output it to the console window

                if (packageDimensions > 50) // If packageDimensions is greater than 50 
                {
                    Console.WriteLine("\nPackage too big to be shipped via Package Express. Have a good day.");
                } // End IF

                else
                {

                } // End ELSE

            } // End ELSE

        } // End MAIN

    } // End CLASS

} // End NAMESPAXE

