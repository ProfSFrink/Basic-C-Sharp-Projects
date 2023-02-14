// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 8: Exception Handling Assignment
// AUTHOR: Steven Partlow
// DATE: 14/02/2023

// GOALS

// 1) Ask the user for their age.
// 2) Display the year the user was born.
// 3) Exceptions must be handled using “try/catch.”
// 4) Display appropriate error messages if the user enters zero or negative numbers.
// 5) Display a general message if an exception was caused by anything else.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptHandAssign
{

    class Program
    {

        static void Main(string[] args)
        {

            // Output all the below text to the console
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Exception Handling Assignment");
            Console.WriteLine("-----------------------------\n");

            // GOAL 1) Ask the user for their age

            Console.Write("Please enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            int userBorn = DateTime.Now.Year - userAge;
            Console.WriteLine(userBorn);

            Console.ReadLine(); // Pause the application
        } // End MAIN

    } // End CLASS

} // End ExceptHandAssign NAMESPACE
