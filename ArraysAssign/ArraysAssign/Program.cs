// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 1: Arrays Assignment
// AUTHOR: Steven Partlow
// DATE: 28/12/2022

// GOALS
// 1. Create a one-dimensional array of strings. Ask the user to select an index of the array and then display the string at that index on the screen.
// 2. Create a one-dimensional array of integers. Ask the user to select an index of the array and then display the integer at that index on the screen.
// 3. Add in a message that displays when the user selects an index that doesn’t exist.
// 4. Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.

using System; // Use the base system library
using System.Collections.Generic; // Use the generic section of the collections library this will allow us to use both lists and arrays

class Program
{
    static void Main()
    {
        // Output all the below text to the display
        Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
        Console.WriteLine("----------------------------------\n");
        Console.WriteLine("Arrays Assignment");
        Console.WriteLine("-----------------");

        bool validChoice = true; // This will control our do while loop, we initally set to true and assume a valid choice from the user

        // GOAL 1. Create a one-dimensional array of strings. Ask the user to select an index of the array and then display the string at that index on the screen.
        do
        {
            // Setup an array of string with five elements assigning the following value to each element starting at index zero
            string[] gameArray = { "Trails in the Sky: First Chapter [PC]", "Vampire Surviors [PC]", "Space Marine [PC]", "Mushihimesama [SWITCH]", "Huntdown [SWITCH]" };


            Console.Write("\nPlease enter a number betweeen 1 and 5: "); // Output this text to the console
            int userChoice = Convert.ToInt32(Console.ReadLine()); // Take the user input and cast to an integer

            if (userChoice < 1 || userChoice > 5)
            {
                // GOAL 3.Add in a message that displays when the user selects an index that doesn’t exist.
                validChoice = false; // As the user has entered an invalid choice we now set this to false
                Console.WriteLine("\nYou have entered an invalid choice!. Please enter a number between 1 and 5, Thank You.");
            } // End IF
            else
            {
                validChoice = true;
                Console.WriteLine("\n" + gameArray[userChoice - 1]);
            } // End ELSE

        } // End DO
        while (!validChoice);



        // GOAL 2. Create a one-dimensional array of integers. Ask the user to select an index of the array and then display the integer at that index on the screen.


        // GOAL 4. Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.


        Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
        Console.ReadLine(); // Pause the application so we can see the output

    } // End MAIN

} // End CLASS (End of Application)
