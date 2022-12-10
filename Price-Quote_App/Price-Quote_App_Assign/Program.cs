// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 11: Price-Quote Assignment
// AUTHOR: Steven Partlow
// DATE: 10/12/2022
//
// GOALS2
// 1) The first line of the program must be: "Welcome to Package Express. Please follow the instructions below." - DONE
// 2) The user must then be prompted for the package weight.
// 3) If the weight is greater than 50, display the error message: "Package too heavy to be shipped via Package Express. Have a good day." At this point, the program must end.
// 4) The user must be prompted for the package width, height and length.
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
            // Goal 1) The first line of the program must be: "Welcome to Package Express." Please follow the instructions below."
            Console.WriteLine("Welcome to Package Express.");
            
            Console.WriteLine("\nPlease follow the instructions below.");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
            Console.ReadLine(); // Pause the application so we can see the output 
        } // End MAIN

    } // End CLASS

} // End NAMESPAXE

