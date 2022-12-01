// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 8: Income Comparison Assignment
// AUTHOR: Steven Partlow
// DATE: 01/12/2022
//
// ASSIGNMENT GOALS:
//
// GOAL 1) Print "Anonymous Income Comparison Program" to the console
// GOAL 2) Print "Person 1" to the console and take in there hourly rate and weekly hours worked
// GOAL 3) Print "Person 2" to the console and take in there hourly rate and weekly hours worked
// GOAL 4) Print "Annual Wage of Person 1:" to the console and calculate their annual salary and output it to the console
// GOAL 5) Print "Annual Wage of Person 2:" to the console and calculate their annual salary and output it to the console
// GOAL 6) Print "Person 1 makes more than Person 2:" to the console and output the result of the boolean operation to the console

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("INCOME COMPARISON ASSIGNMENT");
            Console.WriteLine("----------------------------\n");

            // GOAL 1) Print "Anonymous Income Comparison Program" to the console
            Console.WriteLine("ANOYMOUS INCOME COMPARISON PROGRAM"); // Print this text to the console
            Console.WriteLine("----------------------------------"); // Print this text to the console


            // GOAL 2) Print "Person 1" to the console and take in there hourly rate and weekly hours worked
            Console.WriteLine("\nPERSON 1"); // Print this text to the console
            Console.WriteLine("--------"); // Print this text to the console

            Console.Write("What is your current hourly wage?: "); // Print this text to the console
            double p1HourlyWage = Convert.ToDouble(Console.ReadLine()); // Request the user input the value for variable p1HourlyWage which is defined as a decimal data type

            Console.Write("How many hours do you currently work in a week?: "); // Print this text to the console
            double p1WeeklyHours = Convert.ToDouble(Console.ReadLine()); // Request the user input the value for variable p1WeeklyHours which is defined as a decimal data type

            // GOAL 3) Print "Person 2" to the console and take in there hourly rate and weekly hours worked
            Console.WriteLine("\nPERSON 2"); // Print this text to the console
            Console.WriteLine("--------"); // Print this text to the console

            Console.Write("What is your current hourly wage?: "); // Print this text to the console
            double p2HourlyWage = Convert.ToDouble(Console.ReadLine()); // Request the user input the value for variable p1HourlyWage which is defined as a decimal data type

            Console.Write("How many hours do you currently work in a week?: "); // Print this text to the console
            double p2WeeklyHours = Convert.ToDouble(Console.ReadLine()); // Request the user input the value for variable p1WeeklyHours which is defined as a decimal data type

            // GOAL 4) Print "Annual Wage of Person 1:" to the console and calculate their annual salary and output it to the console
            double p1AnnualWage = (p1HourlyWage * p1WeeklyHours) * 52; // Multiply p1HourlyWage by p1WeeklyHours then multiply the result of this by 52 and store the value in p1AnnualWage
            Console.WriteLine("\nAnnual Wage of Person 1: " + p1AnnualWage); // Concatenate p1AnnualWage to this string and output the result to the console

            // GOAL 5) Print "Annual Wage of Person 2:" to the console and calculate their annual salary and output it to the console
            double p2AnnualWage = (p2HourlyWage * p2WeeklyHours) * 52; // Multiply p2HourlyWage by p2WeeklyHours then multiply the result of this by 52 and store the value in p2AnnualWage
            Console.WriteLine("\nAnnual Wage of Person 2: " + p2AnnualWage); // Concatenate p2AnnualWage to this string and output the result to the console

            // GOAL 6) Print "Person 1 makes more than Person 2:" to the console and output the result of the boolean operation to the console
            Console.WriteLine("\nPerson 1 makes more than Person 2: " + Convert.ToString(p1AnnualWage > p2AnnualWage).ToUpper()); // Compute if p1AnnualWage is greater than p2AnnualWage and then convert the result to uppercase before concatenating it this string and outputting the result to the console window

            Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
            Console.ReadLine(); // Pause the application so we can see the output

            // END OF APPLICATION
        } // End MAIN

    } // End CLASS

} // End NAMESPACE
