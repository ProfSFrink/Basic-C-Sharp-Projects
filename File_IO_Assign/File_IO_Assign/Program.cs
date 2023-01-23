// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 7: File I/O Assignment
// AUTHOR: Steven Partlow
// DATE: 23/01/2023

// GOALS

// 1) Asks the user for a number. - DONE
// 2) Logs that number to a text file. - DONE
// 3) Prints the text file back to the user. - DONE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // We add the IO namespace so we can use file-handling in our program

namespace File_IO_Assign
{
    class Program
    {

        static void Main(string[] args)
        {
            // Output all the below text to the console
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("File I/O Assignment");
            Console.WriteLine("-------------------\n");

            // GOAL 1) Asks the user for a number
            Console.Write("Please enter a number: "); // Write this text to the console
            string userNum = Console.ReadLine(); // Store the user input to the string variable userNum

            // GOAL 2) Logs that number to a text file
            Console.WriteLine("\nWriting to file..."); // Write this text to the console
            File.WriteAllText(@"C:\Users\Steven Partlow\Logs\file_io_assign.txt", userNum); // Save the value of userNum to the file at the end of this path file_io_assign.txt

            // GOAL 3) Prints the text file back to the user
            string fileNum = File.ReadAllText(@"C:\Users\Steven Partlow\Logs\file_io_assign.txt");
            Console.WriteLine("\nReading from file...\n"); // Write this text to the console
            Console.WriteLine(fileNum); // Take the value of fileNum and output to the console

            Console.ReadLine(); // Pause the application
        } // End MAIN

    } // End CLASS

} // End File_IO_Assign Namespace
