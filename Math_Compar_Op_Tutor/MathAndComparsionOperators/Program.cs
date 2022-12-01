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

            // MATH AND COMPARISON OPERATORS TUTORIAL - PART 1

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
            Console.WriteLine("Ten multiplied by Five = " + product.ToString()); // We make use of the ToString() method to concatenate product to this string

            // DIVISION
            int quotient = 100 / 5; // Divide 100 by 5 and store the output in quotient
            Console.WriteLine("One Hundred divided by Five = " + quotient.ToString()); // We make use of the ToString() method to concatenate quotient to this string

            quotient = 100 / 17; // Divide 100 by 17 and store the output in quotient the answer will round down as their is a remainder (15)
            Console.WriteLine("One Hundred divided by Seventeen = " + quotient.ToString()); // We make use of the ToString() method to concatenate quotient to this string

            double secondQuotient = 100.00 / 17.00; // If we make use of the double data type and use numbers with decimal places we will get a more precise answer
            Console.WriteLine("One Hundred divided by Seventeen = " + secondQuotient.ToString()); // We make use of the ToString() method to concatenate secondQuotient to this string

            // REMAINDER (MODULUS OPERATOR)
            int remainder = 10 % 2; // Divide 10 by 2 and store the output in remainder
            Console.WriteLine("The remainder of Ten divided by Two = " + remainder.ToString()); // We make use of the ToString() method to concatenate remainder to this string

            remainder = 11 % 2; // Divide 10 by 2 and store the output in remainder
            Console.WriteLine("The remainder of Elven divided by Two = " + remainder.ToString()); // We make use of the ToString() method to concatenate remainder to this string

            // MATH AND COMPARISON OPERATORS TUTORIAL - PART 2

            Console.WriteLine("\nMATH AND COMPARISON OPERATORS - PART 2");
            Console.WriteLine("--------------------------------------\n");

           // LESS THAN OPERATOR(<)

            bool trueOrFalse = 12 < 5; // Compare if 12 is greater than 5 and store the result as a boolean in trueOrFalse
            Console.WriteLine("Is Tweleve less than five? " + trueOrFalse.ToString().ToUpper()); // We make use of the ToString() method to concatenate trueOrFalse to this string and make it uppercase through use of the ToUpper() method

            // GREATER THAN OPERTOR(>)

            trueOrFalse = 12 > 5; // Compare if 12 is less than 5 and store the result as a boolean in trueOrFalse
            Console.WriteLine("Is Tweleve greater than five? " + trueOrFalse.ToString().ToUpper()); // We make use of the ToString() method to concatenate trueOrFalse to this string and make it uppercase through use of the ToUpper() method

            int roomTemperature = 70; // Declare an integer variable roomTemperature and assign it the value 70
            int currentTemperature = 72; // Declare an integer variable currentTemperature and assign it the value 72

            bool isWarm = currentTemperature > roomTemperature; // Check if currentTemperature is greater than roomTemperature and store the result in boolean isWarm
            Console.WriteLine("Is the value of currentTemperature greater than the value of roomTemperature? " + isWarm.ToString().ToUpper()); // We make use of the ToString() method to concatenate trueOrFalse to this string and make it uppercase through use of the ToUpper() method

            // GREATER OR EQUAL OPERATOR

            currentTemperature = 70; // Reassign currentTemperature with a new value of 70
            isWarm = currentTemperature >= roomTemperature; // Check if currentTemperature is greater or equal to roomTemperature and store the result in boolean isWarm
            Console.WriteLine("Is the value of currentTemperature greater or equal to the value of roomTemperature? " + isWarm.ToString().ToUpper()); // We make use of the ToString() method to concatenate trueOrFalse to this string and make it uppercase through use of the ToUpper() method

            // LESS OR EQUAL OPERATOR

            isWarm = currentTemperature <= roomTemperature; // Check if currentTemperature is less or equal to roomTemperature and store the result in boolean isWarm
            Console.WriteLine("Is the value of currentTemperature less or equal to the value of roomTemperature? " + isWarm.ToString().ToUpper()); // We make use of the ToString() method to concatenate trueOrFalse to this string and make it uppercase through use of the ToUpper() method

            // EXACTLY EQUAL OPERATOR

            isWarm = currentTemperature == roomTemperature; // Check if currentTemperature is exactly equal to roomTemperature and store the result in boolean isWarm
            Console.WriteLine("Is the value of currentTemperature exactly equal to the value of roomTemperature? " + isWarm.ToString().ToUpper()); // We make use of the ToString() method to concatenate trueOrFalse to this string and make it uppercase through use of the ToUpper() method

            // NOT EXACTLY EQUAL OPERATOR

            isWarm = currentTemperature != roomTemperature; // Check if currentTemperature is not exactyly equal to roomTemperature and store the result in boolean isWarm
            Console.WriteLine("Is the value of currentTemperature not equal to the value of roomTemperature? " + isWarm.ToString().ToUpper()); // We make use of the ToString() method to concatenate trueOrFalse to this string and make it uppercase through use of the ToUpper() method

            Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
            Console.ReadLine(); // Pause the application so we can see the output

            // END OF APPLICATION
        } // End MAIN

    } // End CLASS

} // End NAMESPACE
