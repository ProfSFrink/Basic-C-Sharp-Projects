// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 3: Visual Studio Assignment
// AUTHOR: Steven Partlow

using System; // Use the SYSTEM library

namespace myConsoleProject.cs
{
    class Program
    {
        static void Main() // The MAIN application - The first thing executed
        {
            Console.WriteLine("What is your name?"); // Print this text to the console
            string name = Console.ReadLine(); // Take the text inputted by the user and store within variable 'name'
            Console.WriteLine("Hello, " + name + "!"); // Print this text alongside the value stored in 'name' to the console
            Console.Read(); // Do not close the console window until the user presses ENTER
        } // End MAIN

    } // End CLASS

} // End Program
