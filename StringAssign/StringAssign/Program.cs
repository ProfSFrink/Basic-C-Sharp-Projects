// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 12: String Assignment
// AUTHOR: Steven Partlow
// DATE: 13/12/2022
//
// GOALS
// GOAL 1) Concatenate three strings - DONE
// GOAL 2) Convert a string to uppercase - DONE
// GOAL 3) Create a StringBuilder and build a paragraph of text, one sentence at a time - DONE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Strings Assignment");
            Console.WriteLine("------------------\n");

            // GOAL 1) Concatenate three strings

            Console.WriteLine("\nGOAL 1: Concatenate 3 Strings"); // Output this text to the console
            Console.WriteLine("------------------------------"); // Output this text to the console

            string stringOne = "The Legend of Heroes"; // Create string variable stringOne and assign it this value
            string stringTwo = "Trails in the Sky"; // Create string variable stringTwo and assign it this value
            string stringThree = "First Chapter"; // Create string variable stringThree and assign it this value

            Console.WriteLine("String 1: " + stringOne);
            Console.WriteLine("String 2: " + stringTwo);
            Console.WriteLine("String 3: " + stringThree);

            Console.WriteLine("\n" + stringOne + ": " + stringTwo + " - " + stringThree); // Concatenate the above three strings together added characters inbetween them

            // GOAL 2) Convert a string to uppercase

            Console.WriteLine("\nGOAL 2: Convert a string to uppercase"); // Output this text to the console
            Console.WriteLine("--------------------------------------"); // Output this text to the console

            Console.WriteLine("this string was all lowercase but is now all uppercase!.".ToUpper()); // Use the ToUpper() method to convert this string to uppercase

            // GOAL 3) Create a StringBuilder and build a paragraph of text, one sentence at a time

            Console.WriteLine("\nGOAL 3: Create a StringBuilder and build a paragraph of text, one sentence at a time"); // Output this text to the console
            Console.WriteLine("-------------------------------------------------------------------------------------"); // Output this text to the console

            StringBuilder paragraph = new StringBuilder(); // Create a new instance of the StringBuilder object called paragraph

            // Using Charles Dickens "A Tale of Two Cities" for the quote

            paragraph.Append("It was the best of times, it was the worst of times, it was the age of wisdom, it was the age "); // Output this text to the console
            Console.WriteLine("\nLINE 1: " + paragraph); // Concatenate paragrpah to this string

            paragraph.Append("of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season "); // Output this text to the console
            Console.WriteLine("\nLINE 1 + 2: " + paragraph); // Concatenate paragrpah to this string

            paragraph.Append("of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair."); // Output this text to the console
            Console.WriteLine("\nLINE 1 + 2 + 3: " + paragraph); // Concatenate paragrpah to this string

            Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
            Console.ReadLine(); // Pause the application so we can see the output
                                
        } // End MAIN

    } // End CLASS

} // End NAMESPACE
