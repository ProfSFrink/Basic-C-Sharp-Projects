// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 2: Console App Assignment
// AUTHOR: Steven Partlow
// DATE: 31/12/2022

// GOALS

// PART 1
// ------
// 1-1) A one-dimensional array of strings. - DONE
// 1-2) Ask the user to input some text. - DONE
// 1-3) A loop that iterates through each string in the array and adds the user's text input to the end of each string. - DONE
// 1-4) Then create a loop that prints off each string in the array on a separate line. - DONE
// 1-5) Save and execute your code. - DONE

// PART 2
// ------
// 2-1) An infinite loop. - DONE
// 2-2) Save your code. - DONE
// 2-3) Fix the infinite loop so that it will execute properly.
// 2-4) Save and execute your code.

using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // Output all the below text to the display
        Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
        Console.WriteLine("----------------------------------\n");
        
        // PART 1
        Console.WriteLine("Console App Assignment - Part 1"); // Output this text to the console then start a new line
        Console.WriteLine("-------------------------------\n");

        // GOAL 1-1) A one-dimensional array of strings
        string[] games = { "Moon Patrol", "10-Yard Fight", "Battle Chopper", "Lightning Swords", "R-Type", "In the Hunt" }; // Instanstiate an array of string called games and add these six values to the array

        // GOAL 1-2) Ask the user to input some text
        Console.Write("Please enter some text into the application, thank you: "); // Output this text to the console
        string userInput = Console.ReadLine(); // Store the text the user enters into the string variable userInput

        // GOAL 1-3) A loop that iterates through each string in the array and adds the user's text input to the end of each string

        Console.WriteLine(); // Adds a blank line to the console window
        for (int i = 0; i < 6; i++) // Start a FOR loop using counter variable i start at zero and keep iterating until i is six or greater
        {
            games[i] = games[i] + " " + userInput; // Concatenate the current value of the games array with the userinput and store this new string in the current index of the games array

            // GOAL 1-4) Then create a loop that prints off each string in the array on a separate line (DOING THIS AS PART OF THE SAME LOOP AS MORE EFFICENT THAN USING TWO SEPERATE FOR LOOPS)

            Console.WriteLine(games[i]); // Output the current value of games to the console
        } // End FOR

        // PART 2
        Console.WriteLine("Console App Assignment - Part 2"); // Output this text to the console then start a new line
        Console.WriteLine("-------------------------------\n");

        //// GOAL 2 - 1) An infinite loop
        //bool infinite = true; // Initilise a boolean variable and set it to true

        //while (infinite) // This is an infinite while loop that will not stop looping as infinite will always be set to true
        //{
        //    Console.WriteLine("This is an infinite loop that will never end!. You will have force the application to quit!."); // Output this text to the console
        //} // End While

        // GOAL 2-3) Fix the infinite loop so that it will execute properly
        bool infinite = true; // Initilise a boolean variable and set it to true

        while (infinite) // This loop will now execute once as it will change infinite to false after one loop, exiting the while loop
        {
            infinite = false; // Set the boolean variable infinite to false to exit the while loop
            Console.WriteLine("The while loop will now exit correctly!"); // Output this text to the console
        } // End While

        Console.ReadLine(); // Pause the application
    } // End MAIN

} // End CLASS

