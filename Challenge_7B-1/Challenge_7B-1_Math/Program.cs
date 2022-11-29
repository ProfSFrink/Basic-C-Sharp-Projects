// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 8: Challenge 7B-1: Math Operations 
// AUTHOR: Steven Partlow
// DATE: 29/11/2022

// GOALS FOR THIS CHALLENGE
// 1) Add two numbers and display the output - DONE
// 2) Subtract two numbers and display the output - DONE
// 3) Multiply two numbers and display the output - DONE
// 4) Divide two numbers and display the output - DONE
// BONUS) Divide two numbers then calculate the remainder and display the output - DONE 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_7B_1_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program Introduction

            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("CHALLENGE 7B-1: MATH OPERATIONS");
            Console.WriteLine("-------------------------------\n");
            Console.WriteLine("Perform the following math operations in C# and display the output:\n");

            // 1) Add two numbers and display the output
            int num1 = 43; // Initialise the variable as an integer and assign it this value
            int num2 = 41; // Initialise the variable as an integer and assign it this value
            int answer = num1 + num2; // Initialise the variable as an integer and assign it the value of num1 plus num2 (84)
            Console.WriteLine("ADDITION: " + num1 + " + " + num2 + " = " + answer); // Output the answer to the console window

            // 2) Subtract two numbers and display the output
            num1 = 70; // Re-assign variable num1 with a new value
            num2 = 66; // Re-assign variable num2 with a new value
            answer = num1 - num2; // Re-assign answer with answer to num1 minus num2
            Console.WriteLine("SUBTRACTION: " + num1 + " - " + num2 + " = " + answer); // Output the answer to the console window

            // 3) Multiply two numbers and display the output
            num1 = 843; // Re-assign variable num1 with a new value
            num2 = 568; // Re-assign variable num1 with a new value
            answer = num1 * num2; // Re-assign answer with answer to num1 multiplied by num2
            Console.WriteLine("MULTIPLACATION: " + num1 + " * " + num2 + " = " + answer); // Output the answer to the console window

            // 4) Divide two numbers and display the output
            num1 = 122; // Re-assign variable num1 with a new value
            num2 = 3; // Re-assign variable num1 with a new value
            answer = num1 / num2; // Re-assign answer with answer to num1 divided by num2
            Console.WriteLine("DIVISION: " + num1 + " / " + num2 + " = " + answer); // Output the answer to the console window

            // BONUS) Divide two numbers then calculate the remainder and display the output
            num1 = 587; // Re-assign variable num1 with a new value
            num2 = 539; // Re-assign variable num1 with a new value
            answer = num1 % num2; // Re-assign answer with answer to num1 divided by num2 and calculate the remainder
            Console.WriteLine("REMAINDER: " + num1 + " % " + num2 + " = " + answer + "\n"); // Output the answer to the console window

            Console.WriteLine("Press the ENTER key to exit the application"); // Output this text to the display
            Console.ReadLine(); // Pause the application so we can see the output
            // END OF APPLICATION

        } // End MAIN

    } // End CLASS

} // End NAMESPACE

