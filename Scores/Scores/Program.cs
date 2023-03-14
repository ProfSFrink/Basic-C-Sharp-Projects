// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 12: Learning .NET Core
// AUTHOR: Steven Partlow
// DATE: 14/03/2023

using System;
using System.IO;

namespace Scores
{

    class Program
    {

        static void Main(string[] args)
        {
            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Learning .NET Core Tutorial");
            Console.WriteLine("---------------------------\n");

            Console.Write("Please enter in your first name: "); // Output this text to the console
            string date = DateTime.Today.ToShortDateString(); // Create a string variable called date and assign it todays date and cast that to a string
            string uName = Console.ReadLine(); // Take user input and assign it to the string variable uName
            string msg = $"\nWelcome back {uName}. Today is {date}."; // Concatenate the uName and date variables into the string msg
            Console.WriteLine(msg); // Output the value of the msg variable to the screen

            string path = @"C:\Users\pitma\sp\Basic-C-Sharp-Projects\Scores\Scores\StudentScores.txt"; // A string to represent the path of our file containg our student test scores
            string[] lines = File.ReadAllLines(path); // Create an array of strings called lines and then open the file "StudentScores.txt" from the path variable and read all values into our string array

            double tScore = 0.0; // A double variable to present our total student test scores which by default starts at zero

            Console.WriteLine("\nStudent Scores: "); // Create a new line, output this text to the console, then create another new line
            foreach (string line in lines) // Iterate through the string array lines and assign each instance to the local string variable line
            {

                Console.Write("\n" + line);// Output the current value of line to the console window

                double score = Convert.ToDouble(line); // Take the current value of line and cast it to a double variable then assign it to score
                tScore += score; // Take the current value of score and add it the current value of tScore

            } // End FOREACH

            double avgScore = tScore / lines.Length; // Divide the value of tScore by the number of values within the lines array
            Console.WriteLine("\n\nTotal of " + lines.Length + " student scores. \tAverage score: " + avgScore);


            Console.WriteLine("\nPress any key to exit."); // Output this text to the console
            Console.ReadKey(); // Pause the application until the user presses any key

        } // End MAIN

    } // End CLASS Program

} // End NAMESPACE Scores
