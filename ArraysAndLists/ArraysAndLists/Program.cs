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

        //// Arrays and Lists Tutorial Part 1

        //int[] numArray = new int[5]; // Create an array object containing five integer elements

        //numArray[0] = 5; // Set the first element of the array numArray to 5
        //numArray[1] = 2; // Set the second element of the array numArray to 2
        //numArray[2] = 10; // Set the third element of the array numArray to 10
        //numArray[3] = 200; // Set the fourth element of the array numArray to 200
        //numArray[4] = 5000; // Set the fifth element of the array numArray to 5000

        ////Console.WriteLine(numArray[3]); // Print to the console the value store in the fourth element of the numArray array

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 }; // This will again create an array with five elements but will fill those five elements with the values that are
        //                                                     // between the curly braces, this achieves the same as above but is cleaner

        ////Console.WriteLine(numArray1[3]); // Print to the console the value store in the fourth element of the numArray1 array

        //// Arrays and Lists Tutorial Part 2

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 }; // This will create and array and fill it with the values that are in between the curly braces we do not                                                             need the new clause as C# can figure out that we are using the integer data type

        ////Console.WriteLine(numArray2[3]); // Print to the console the value store in the fourth element of the numArray2 array

        //numArray2[5] = 650; // Change the value stored in sixth element within numArray2

        //Console.WriteLine(numArray2[5]); // Print to the console the value store in the fifth element of the numArray2 array
        //Console.ReadLine(); // Pause the application so we can view the output

        List<int> intList = new List<int>(); // This will instanstiate a new list consisting of integer data types called intList
        intList.Add(4); // Add an integer value of 4 to the list intList
        intList.Add(10); // Add an integer value of 10 to the list intList
        intList.Remove(10); // Remove the value 10 from the list intList

        //Console.WriteLine(intList[0]); // Output the value at element one from the list intList to the console window

        List<string> stringList = new List<string>(); // This will instanstiate a new list consisting of integer data types called stringList
        stringList.Add("Hello"); // Add a string value 'Hello' to the list stringList
        stringList.Add("Jesse"); // Add a string value 'Jesse' to the list stringList
        stringList.Remove("Jesse"); // Remove the value 'Jesse' from the list stringList

        Console.WriteLine(stringList[0]); // Output the value at element one from the list stringList to the console window
        Console.ReadLine(); // Pause the application to display the output

    } // End MAIN

} // End CLASS
