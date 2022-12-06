// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 10: Challenge 10B-1: NOT EQUALS (!=) Operator
// AUTHOR: Steven Partlow
// DATE: 06/12/2022
//
// GOAL
//
// 1) Write and execute C# code that utilises the NOT EQUALS (!=) operator and display the output to the console - DONE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge10B_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("CHALLENGE 10B-1: NOT EQUALS (!=) Operator");
            Console.WriteLine("-----------------------------------------\n");

            Console.Write("Do you like RPGs (Role-Playing Games)?: "); // Output this texts to the console
            string answerOne = Console.ReadLine().ToUpper(); // Convert the input to uppercase and then assign it to the variable answerOne

            Console.Write("Do you like Strategy Games?: "); // Output this texts to the console
            string answerTwo = Console.ReadLine().ToUpper(); // Convert the input to uppercase and then assign it to the variable answerTwo

            if (answerOne != "NO" && answerTwo != "NO") // If answerOne does NOT equal NO and answerTwo does NOT equal NO execute this IF statement
            {
                Console.WriteLine("\nGood, I recommend Tactics Ogre Reborn it is a great strategy RPG!"); // Output this texts to the console
                Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
                Console.ReadLine(); // Pause the application so we can see the output 
            } // End IF
            else if (answerOne != "NO" && answerTwo != "YES") // If answerOne does NOT equal NO and answerTwo does NOT equal YES execute this IF statement
            {
                Console.WriteLine("\nThen try Chrono Trigger which is a great RPG for beginners!");
                Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
                Console.ReadLine(); // Pause the application so we can see the output 
            } // End IF
            else if (answerOne != "YES" && answerTwo != "NO") // If answerOne does NOT equal YES and answerTwo does NOT equal NO execute this IF statement
            {
                Console.WriteLine("\nGood, I recommend X-COM 2 it is superb startegy game!"); // Output this texts to the console
                Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
                Console.ReadLine(); // Pause the application so we can see the output 
            } // End ELSE IF
            else if (answerOne != "YES" && answerTwo != "YES") // If answerOne does NOT equal YES and answerTwo does NOT equal YES execute this IF statement
            {
                Console.WriteLine("\nThen I recommend Vampire Surviors a simple shoot em up that is very addictive!"); // Output this texts to the console
                Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
                Console.ReadLine(); // Pause the application so we can see the output 
            } // End ELSE IF

        } // End MAIN

    } // End CLASS

} // End NAMESPACE
