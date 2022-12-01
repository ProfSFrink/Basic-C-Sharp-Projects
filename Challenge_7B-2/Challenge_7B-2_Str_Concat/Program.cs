// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 7: Challenge 7B-2: String Concatenation 
// AUTHOR: Steven Partlow
// DATE: 29/11/2022
//
// GOAL 1): Perform a math operation of a string

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_7B_2_Str_Concat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program Introduction

            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("CHALLENGE 7B-2: STRING CONCATENATION");
            Console.WriteLine("------------------------------------\n");
            Console.WriteLine("Perform a math operation on string and display the output:\n");

            string strPartOne = "The Legend of Heroes"; // Set string variable strPartOne to this text
            Console.WriteLine("STRING #1: " + strPartOne); // Concatenate this text with strPartOne

            string strPartTwo = "Trails in the Sky"; // Set variable strPartTwo to this text
            Console.WriteLine("STRING #2: " + strPartTwo); // Concatenate this text with strPartTwo

            string strPartThree = "First Chapter"; // Set variable strPartThree to this text
            Console.WriteLine("STRING #3: " + strPartThree + "\n"); // Concatenate this text with strPartThree

            // Concatenate this text with the three string variables we have defined above and output the result to the display
            Console.WriteLine("FULL STRING: " + strPartOne + ": " + strPartTwo + ": " + strPartThree); 

            Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
            Console.ReadLine(); // Pause the application so we can see the output
            // END OF APPLICATION
        } // End MAIN

    } // End CLASS

} // End NAMESPACE
