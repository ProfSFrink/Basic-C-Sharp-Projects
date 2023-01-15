// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 6: Structs Assignment
// AUTHOR: Steven Partlow
// DATE: 15/01/2023

// GOALS

// 1) Create a struct called Number and give it the property "Amount" and have it be of data type decimal. - DONE
// 2) In the Main() method, create an object of data type Number and assign an amount to it. - DONE
// 3) Print this amount to the console. - DONE

using System;

namespace Structs_Assign
{

    class Program
    {

        static void Main(string[] args)
        {

            // Output all the below text to the console
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Structs Assignment");
            Console.WriteLine("------------------\n");

            // GOAL 2) In the Main() method, create an object of data type Number and assign an amount to it

            Number myFirstStruct; // Create an instance of the Number struct called myOwnStruct
            myFirstStruct.amount = 474; // Assign this value to the amount property of the struct myFirstStruct

            // GOAL 3) Print this amount to the console
            Console.WriteLine("AMOUNT: " + myFirstStruct.amount); // Concatenate this string with the amount property of myFirstStruct and output it to the console

            Console.ReadLine(); // Pause the application

        } // End MAIN

    } // End CLASS

} // End Structs_Assign NAMESPACE
