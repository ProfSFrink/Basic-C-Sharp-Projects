// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 1: Arrays and Lists Tutorial
// AUTHOR: Steven Partlow
// DATE: 27/12/2022

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        // Output all the below text to the display
        Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
        Console.WriteLine("----------------------------------\n");
        Console.WriteLine("Arrays and Lists Tutorial");
        Console.WriteLine("-------------------------\n");

        int[] numArray = new int[5]; // Create an array object containing five integer elements

        numArray[0] = 5; // Set the first element of the array numArray to 5
        numArray[1] = 2; // Set the second element of the array numArray to 2
        numArray[2] = 10; // Set the third element of the array numArray to 10
        numArray[3] = 200; // Set the fourth element of the array numArray to 200
        numArray[4] = 5000; // Set the fifth element of the array numArray to 5000

        int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 }; // This will again create an array with five elements but will fill those five elements with the values that are
                                                             // between the curly braces, this achieves the same as above but is cleaner 

        Console.WriteLine(numArray1[3]); // Print to the console the value store in the fourth element of the numArray array
        Console.ReadLine(); // Pause the application so we can view the output

    } // End MAIN

} // End CLASS
