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
// 6) Next, multiply the three dimensions (height, width, and length) together and multiply the product by the weight. Finally, divide the outcome by 100. - DONE
// 7) Display the quote to the user as an amount in pounds sterling. - DONE
// 8) Thank the user for using the application and end the program. - DONE


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

            Console.WriteLine("\nPackage Weight: " + packageWeight + "kg"); // Concatenate packageWeight into this string and display to the console window

            // GOAL 3) If the weight is greater than 50, display the error message: "Package too heavy to be shipped via Package Express. Have a good day." At this point, the program must end

            if (packageWeight > 50) // If packageWeight is greater than 50 execute inform the user the package is too heavy to be shipped and end the program
            {
                Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Have a good day."); // Print this text to the console
            } // End IF

            else // If the package is less than 50 kilos then we execute the rest of the program
            {
                // GOAL 4) The user must be prompted for the package width, height and length

                Console.Write("\nWhat is the width of your package in centimeters: "); // Print this text to the console
                decimal packageWidth = Convert.ToDecimal(Console.ReadLine()); // Ask the user for the package width and cast it to a decimal data type called packageWidth

                Console.Write("\nWhat is the height of your package in centimeters: "); // Print this text to the console
                decimal packageHeight = Convert.ToDecimal(Console.ReadLine()); // Ask the user for the package height and cast it to a decimal data type called packageHeight

                Console.Write("\nWhat is the length of your package in centimeters: "); // Print this text to the console
                decimal packageLength = Convert.ToDecimal(Console.ReadLine()); // Ask the user for the package length and cast it to a decimal data type called packageLength

                Console.WriteLine("\nPackage Width: " + packageWidth + "cm"); // Concatenate packageWidth into this string and then display to the console window
                Console.WriteLine("Package Height: " + packageHeight + "cm"); // Concatenate packageHeight into this string and then display to the console window
                Console.WriteLine("Package Length: " + packageLength + "cm"); // Concatenate packageLength into this string and then display to the console window


                // GOAL 5) If the total dimensions of the package is greater than 50, display the error message: "Package too big to be shipped via Package Express." At this point, the program must end

                decimal packageDimensions = packageWidth + packageHeight + packageLength; // Calculate the total dimensions of the package store the result in packageDimension

                Console.WriteLine("\nTotal Package Dimensions: " + (packageDimensions) + "cm"); // Concatenate packageDimensions into this string and output it to the console window

                if (packageDimensions > 50) // If packageDimensions is greater than 50 inform user that the dimensions of the package are too big and end the program 
                {
                    Console.WriteLine("\nPackage too big to be shipped via Package Express. Have a good day.");
                } // End IF

                else // If packageDimensions are less than 50 execute the rest of the program
                {
                    Console.WriteLine("\nPackage Weight: " + packageWeight + "kg"); // Concatenate packageWeight into this string and display to the console window
                    Console.WriteLine("Total Package Dimensions: " + (packageDimensions) + "cm"); // Concatenate packageDimensions into this string and output it to the console window

                    // GOAL 6) Next, multiply the three dimensions (height, width, and length) together and multiply the product by the weight. Finally, divide the outcome by 100
                    
                    /* We calculate the price to ship the package by multiplying the width, height and length then taking the result of this and multiplying it by the package weight then dividing the result of this calculation by 100. The Math.Round method rounds the answer to 2 decimal places for our price quote to be able to work in pounds sterling (Pounds / Pence). We then finally store the result of this calculation to the variable priceQuote which is a decimal data type as it is a value representing currency */
                    decimal priceQuote = Math.Round( ( (packageWidth * packageHeight * packageLength) * packageWeight) / 100, 2);

                    // GOAL 7) Display the quote to the user as an amount in pounds sterling

                    Console.WriteLine("\nYour estimated total for shipping this package is: £" + Convert.ToString(priceQuote)); // Cast priceQuote to a string and concatenate with this text and then output the resulting string to the console

                } // End ELSE

            } // End ELSE

            // GOAL 8) Thank the user for using the application and end the program

            Console.WriteLine("\nThank you for using the Package Express Price Quoting Application. Were glad we could be of assistance."); // Print this text this to the console
            Console.WriteLine("Have a pleasent day!"); // Output this text to the console
            Console.WriteLine("\nPress ENTER to exit the application"); // Output this text to the console
            Console.ReadLine(); // Pause the application

            // End of Application

        } // End MAIN

    } // End CLASS

} // End NAMESPACE

