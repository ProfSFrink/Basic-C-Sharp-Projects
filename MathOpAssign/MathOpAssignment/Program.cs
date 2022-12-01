// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 8: Math Operation Assignment
// AUTHOR: Steven Partlow
// DATE: 01/12/2022
//
// ASSIGNMENT GOALS:
//
// 1) - Take an input, multiply it by 50 then output the result NOTE: Input must accept numbers larger than 10,000,000 - DONE
// 2) - Take an input, add 25 to it and output the result - DONE
// 3) - Take an input, divide it by 12.5 and output the result - DONE
// 4) - Take an input, check if it is greater than 50 and output the true / false result - DONE
// 5) - Take an input, divide it by 7, and output the remainder - DONE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOpAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("MATH OPERATION ASSIGNMENT");
            Console.WriteLine("-------------------------\n");

            // GOAL 1) - Take an input, multiply it by 50 then output the result NOTE: Input must accept numbers larger than 10,000,000
            Console.Write("Enter a number greater, we will multiply it by 50: "); // Ask the user to input a integer between 0 and 10,000,000
            double goal1Num = Convert.ToDouble(Console.ReadLine()); // Convert the input from a string to a double and store it in goal1Num

            Console.WriteLine("The number you have entered multiples by 50 = " + Convert.ToString(goal1Num * 50)); // Use the ToString() method to concatenate the result of goal1Num multiplied by 50 to this string

            // GOAL 2) - Take an input, add 25 to it and output the result
            Console.Write("\nEnter a number, we will add 25 to it : "); // Ask the user to input a number
            int goal2Num = Convert.ToInt32(Console.ReadLine()); // Convert the input from a string to an integer and store it in goal2Num

            Console.WriteLine("The number you have entered plus 25 is = " + Convert.ToString(goal2Num + 25)); // Use the ToString() method to concatenate goal2Num plus 25 to this string

            // GOAL 3) - Take an input, divide it by 12.5 and output the result
            Console.Write("\nEnter a number to be divided by 12.5 : "); // Ask the user to input a number
            double goal3Num = Convert.ToDouble(Console.ReadLine()); // Convert the input from a string to a double and store it in goal3Num

            Console.WriteLine("The number you have entered divided by 12.5 is = " + Convert.ToString(goal3Num / 12.5)); // Use the ToString() method to concatenate goal3Num divided by 12.5 to this string

            // GOAL 4) - Take an input, check if it is greater than 50 and output the true / false result
            Console.Write("\nEnter a number, we will check if it is greater than 50: "); // Ask the user to input a number
            double goal4Num = Convert.ToDouble(Console.ReadLine()); // Convert the input from a string to a double and store it in goal4Num

            bool goal4Result = goal4Num > 50; // Check if goal4Num is greater than 50 store the result as boolean goal4Result
            Console.WriteLine("Is the number you have entered greater than 50: " + Convert.ToString(goal4Result).ToUpper()); // Use the ToString() method to concatenate goal4Num is greater than 50 to this string and then use the ToUpper() method to capitialise the output

            // GOAL 5) - Take an input, divide it by 7, and output the remainder
            Console.Write("\nEnter a number, we will divide it by 7 and output the remainder: "); // Ask the user to input a number
            double goal5Num = Convert.ToDouble(Console.ReadLine()); // Convert the input from a string to a double and store it in goal5Num

            Console.WriteLine("The number you have entered divided by 7 is " + Convert.ToString(goal5Num / 7) + " the remainder of which is " + Convert.ToString(goal5Num % 7)); // Use the ToString() method to concatenate the result and remainder of goal5Num divided by 7 to this string

            Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
            Console.ReadLine(); // Pause the application so we can see the output

            // END OF APPLICATION
        } // End MAIN

    } // End CLASS

} // End NAMESPACE
