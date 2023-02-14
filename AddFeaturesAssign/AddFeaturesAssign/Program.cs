// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 8: Additional Features Assignment
// AUTHOR: Steven Partlow
// DATE: 13/02/2023

// GOALS

// 1) Create a const variable - DONE
// 2) Create a variable using the keyword "var” - DONE
// 3) Chain two constructors together - DONE

using System;

namespace AddFeaturesAssign
{

    class Program
    {

        static void Main(string[] args)
        {
            // GOAL 1) Create a const variable

            const string headerText = "PITMAN TRAINING / THE TECH ACADEMY"; // Create a constant variable called headerText which is a string
            const string introText = "Additional Features Assignment"; // Create a constant variable called introText which is a string

            // Output all the below text to the console
            Console.WriteLine(headerText);
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine(introText);
            Console.WriteLine("------------------------------\n");

            // GOAL 2) Create a variable using the keyword "var”

            /* Create a new instance of the Game class called gameOne, this uses the original constructor and passes in the name, platform and release year, we also declare the instance using the var keyword as it is implicit what data type the variable is */
            var gameOne = new Game("Megaman Legacy Collection", "Nintendo Switch", 2015);

            /* Create a new instance of the Game class called gameTwo, this uses the call chain constructor and passes in the name and platform but no release year as the game came out during the current year so is not needed, we also declare the instance using the var keyword as it is implicit what data type the variable is */
            var gameTwo = new Game("Fire Emblem Engage", "Nintendo Switch");

            /* Output gameOne to the console */

            Console.ForegroundColor = ConsoleColor.Yellow; // Change console text colour to Yellow
            Console.WriteLine("GAME ONE"); // Output this text to the console
            Console.WriteLine("========\n"); // Output this text to the console

            Console.ForegroundColor = ConsoleColor.Red; // Change console text colour to Red
            Console.Write("NAME: "); // Output this text to the console

            Console.ForegroundColor = ConsoleColor.White; // Change console text colour to White
            Console.Write(gameOne.Name + "\n"); // Output this text to the console

            Console.ForegroundColor = ConsoleColor.Red; // Change console text colour to Red
            Console.Write("PLATFORM: "); // Output this text to the console

            Console.ForegroundColor = ConsoleColor.White; // Change console text colour to White
            Console.Write(gameOne.Platform + "\n"); // Output this text to the console

            Console.ForegroundColor = ConsoleColor.Red; // Change console text colour to Red
            Console.Write("RELEASE YEAR: "); // Output this text to the console

            Console.ForegroundColor = ConsoleColor.White; // Change console text colour to White
            Console.Write(gameOne.ReleaseYear + "\n"); // Output this text to the console

            /* Output gameTwoe to the console */

            Console.ForegroundColor = ConsoleColor.Yellow; // Change console text colour to Yellow
            Console.WriteLine("GAME TWO"); // Output this text to the console
            Console.WriteLine("========\n"); // Output this text to the console

            Console.ForegroundColor = ConsoleColor.Red; // Change console text colour to Red
            Console.Write("NAME: "); // Output this text to the console

            Console.ForegroundColor = ConsoleColor.White; // Change console text colour to White
            Console.Write(gameTwo.Name + "\n"); // Output this text to the console

            Console.ForegroundColor = ConsoleColor.Red; // Change console text colour to Red
            Console.Write("PLATFORM: "); // Output this text to the console

            Console.ForegroundColor = ConsoleColor.White; // Change console text colour to White
            Console.Write(gameTwo.Platform + "\n"); // Output this text to the console

            Console.ForegroundColor = ConsoleColor.Red; // Change console text colour to Red
            Console.Write("RELEASE YEAR: "); // Output this text to the console

            Console.ForegroundColor = ConsoleColor.White; // Change console text colour to White
            Console.Write(gameTwo.ReleaseYear + "\n"); // Output this text to the console


            Console.ReadLine(); // Pause the application
        } // End MAIN

    } // End CLASS

} // End AddFeaturesAssign NAMESPACE
