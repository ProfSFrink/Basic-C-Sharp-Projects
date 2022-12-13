// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 12: String Tutorial
// AUTHOR: Steven Partlow
// DATE: 13/12/2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jesse"; // Create a string variable called name
            string quote = "The man said, \"Hello\", Jesse. \n Hello on new line. \n \t Hello on a tab."; // Create a string called quote using "\" use the double-quotes, "\n" to start a newline and "\t" to tab in the console.
            string fileName = @"C:\Users\Jesse"; // The "@" tells the compiler that everything in the string is valid and does not need to be escaped

            bool trueOrFalse = name.Contains("s"); // Check if the variable name contains the character "s" and return true if it does
            trueOrFalse = name.EndsWith("s"); // Check if the variable name ends with the character "s" and return true if it does

            int length = name.Length; // Will return the length of the variable name as an integer

            name = name.ToUpper(); // Will convert the string name to uppercase
            name = name.ToLower(); // Will convert the string name to lowercase

            StringBuilder sb = new StringBuilder(); // Create a new StringBuilder object called sb

            sb.Append("My name is Jesse"); // Append this text to StringBuilder object sb

            Console.WriteLine(sb); // Print sb to the console
            Console.ReadLine(); // Pause the application


        } // End MAIN

    } // End CLASS

} // End NAMESPACE
