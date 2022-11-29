// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 8: Challenge 7B-1: Math Operations 
// AUTHOR: Steven Partlow
// DATE: 29/11/2022

// GOALS FOR THIS CHALLENGE
// 1) Add two numbers and display the output - DONE
// 2) Subtract two numbers and display the output
// 3) Multiply two numbers and display the output
// 4) Divide two numbers and display the output

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
            // 1) Add two numbers and display the output
            int num1 = 43; // Initialise the variable as an integer and assign it this value
            int num2 = 41; // Initialise the variable as an integer and assign it this value
            int answer = num1 + num2; // Initialise the variable as an integer and assign it the value of num1 plus num2 (84)
            Console.WriteLine(num1 + " + " + num2 + " = " + answer); // Output the answer to the console window

            // 2) Subtract two numbers and display the output
            num1 = 70; // Re-assign variable num1 with a new value
            num2 = 66; // Re-assign variable num2 with a new value
            answer = num1 - num2; // Re-assign answer with answer to num1 minus num2
            Console.WriteLine(num1 + " + " + num2 + " = " + answer); // Output the answer to the console window
            Console.ReadLine(); // Pause the application so we can see the output
        }
    }
}
