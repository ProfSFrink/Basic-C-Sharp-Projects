// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 2: Iteration Tutorial
// AUTHOR: Steven Partlow
// DATE: 29/12/2022

using System; // Use the base system library
using System.Collections.Generic; // Use the generic section of the collections library this will allow us to use both lists and arrays


class Program
{
    static void Main(string[] args)
    {
        // Output all the below text to the display
        Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
        Console.WriteLine("----------------------------------\n");
        Console.WriteLine("Iteration Tutorial");
        Console.WriteLine("------------------");

        int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 }; // Instansiate a new array consisting of nine integer values to represent test scores

        for (int i = 0; i < testScores.Length; i++) // Start a FOR loop, with the counter variable i which will count from zero to the lenghth of the testScores array
                                                    // After each iteration of the loop i will increment by one
        {
            if (testScores[i] > 85) // If the current value in testScores we are checking is greater than 85
            {
                Console.WriteLine("Passing test score: " + testScores[i]); // Print the test score to the console
            } // End IF

        } // End FOR

        string[] names = { "Jesse", "Erik", "Daniel", "Adam" }; // Instansiate a new array consisting of four string values to represent peoples names

        for (int j = 0; j < names.Length; j++) // Start a FOR loop, with the counter variable j which count from zero to the length of the testScores array
                                               // After each iteration of the loop j will increment by one
        {
            if (names[j] == "Jesse") // If the current values in names equals Jesse then 
            {
                Console.WriteLine(names[j]); // Print the name to the console
            } // End IF

        } // End FOR

    } // End MAIN

} // End CLASS
