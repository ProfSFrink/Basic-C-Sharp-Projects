// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 8: Math and Comparison Operators Tutorial
// AUTHOR: Steven Partlow
// DATE: 01/12/2022
//
// The code from the Math and Comparison Operators Tutorial Videos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparsionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("MATH AND COMPARISON OPERATORS - PART 1");
            Console.WriteLine("--------------------------------------\n");

            // ADDITION
            int total = 5 + 10; // Add 5 to 10 and assign the result to total
            int otherTotal = 12 + 22; // Add 12 to 22 and assign the result to otherTotal
            int combined = total + otherTotal; // Add total to OtherTotal and assign the result to combined

            Console.WriteLine("Five plus Ten = " + total.ToString()); // We make use of the ToString() method to concatenate total to this string
            Console.WriteLine("Tweleve plus Twenty-Two = " + otherTotal.ToString());
            Console.WriteLine("Fiveteen plus Thirty-Four = " + combined.ToString()); // Display the value of combined

            // SUBTRACTION
            int difference = 10 - 5; // Subtract 5 from 10 and assign the result to difference
            Console.WriteLine("Ten minus Five = " + difference.ToString()); // We make use of the ToString() method to concatenate total to this string

           // MULTIPLACATION
            int product = 10 * 5; // Multiply 10 by 5 and assign the result to product
            Console.WriteLine("Ten multiplied by Five = " + product.ToString()); // Output the value of product to the console window

            // DIVISION
            int quotient = 100 / 5; // Divide 100 by 5 and store the output in quotient
            Console.WriteLine("One Hundred divided by Five = " + quotient.ToString()); // Output the value of quotient to the console window

            quotient = 100 / 17; // Divide 100 by 17 and store the output in quotient the answer will round down as their is a remainder (15)
            Console.WriteLine("One Hundred divided by Seventeen = " + quotient.ToString()); // Output the value of quotient to the console window

            double secondQuotient = 100.00 / 17.00; // If we make use of the double data type and use numbers with decimal places we will get a more precise answer
            Console.WriteLine("One Hundred divided by Seventeen = " + secondQuotient.ToString()); // Output the value of secondQuotient to the console window

            // REMAINDER (MODULUS OPERATOR)
            int remainder = 10 % 2; // Divide 10 by 2 and store the output in remainder
            Console.WriteLine("The remainder of Ten divided by Two = " + remainder.ToString()); // Output the value of remainder to the console window

            remainder = 11 % 2; // Divide 10 by 2 and store the output in remainder
            Console.WriteLine("The remainder of Elven divided by Two = " + remainder.ToString()); // Output the value of remainder to the console window

            Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
            Console.ReadLine(); // Pause the application so we can see the output
        } // End MAIN

    } // End CLASS

} // End NAMESPACE
