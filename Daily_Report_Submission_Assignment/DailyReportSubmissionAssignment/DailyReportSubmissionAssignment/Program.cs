// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 7: Daily Report Assignment Submission 
// AUTHOR: Steven Partlow
// DATE: 28/11/2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pitman Training"); // Print this text then start a new line in the console window
            Console.WriteLine("---------------\n"); // Print this text then start a new line in the console window
            Console.WriteLine("Student Daily Report\n"); // Print this text to the console window

            Console.Write("What course are you in? "); // Print this text to the console window
            string course = Console.ReadLine(); // Store the user input into string 'course'

            Console.Write("What page number? "); // Print this text to the console window
            short pageNumber = Convert.ToInt16(Console.ReadLine()); // Take the user input and convert it to a short data type and store the result in variable 'pageNumber'

            Console.Write("Do you need help with anything? Please answer \"true\" or \"false\": "); // Print this text to the console window
            bool needHelp = Convert.ToBoolean(Console.ReadLine()); // Take the user input and convert it to a boolean data type and store the result in variable 'needHelp'

            Console.Write("Were there any positive experiences you’d like to share? Please provide specifics: "); // Print this text to the console window
            string positiveExperiences = Console.ReadLine(); // Store the user input into string 'positiveExperiences'

            Console.Write("Is there any other feedback you’d like to provide? Please be specific: "); // Print this text to the console window
            string otherFeedback = Console.ReadLine(); // Store the user input into string 'otherFeedback'

            Console.Write("How many hours did you study today? "); // Print this text to the console window
            byte hoursStudied = Convert.ToByte(Console.ReadLine()); // Take the user input and convert it to a byte data type and store the result in variable 'hoursStudied'

            Console.Clear(); // Clear the console window
            Console.WriteLine("Your responses were as follows: \n");
            Console.WriteLine("What course are you in? " + course); // Print the value of 'course' to the console window
            Console.WriteLine("What page number? " + pageNumber.ToString()); // Convert 'pageNumber' back to a string then print it's value to the console window
            Console.WriteLine("Do you need help with anything? " + needHelp.ToString()); // Convert 'needHelp' back to a string then print it's value to the console window
            Console.WriteLine("Were there any positive experiences you’d like to share? " + positiveExperiences); // Print the value of 'positiveExperiences' to the console window
            Console.WriteLine("Is there any other feedback you’d like to provide?" + otherFeedback); // Print the value of 'otherFeedback' to the console window
            Console.WriteLine("How many hours did you study today? " + hoursStudied.ToString()); // Convert 'hoursStudied' back to a string then print it's value to the console window

            Console.WriteLine("\nThank you for your responses.  An Instructor will respond shortly.  Have a great day!\n"); // Print this text to the console window
            Console.WriteLine("Press ENTER to exit the application"); // Print this text to the console window
            Console.Read(); // Pause the application so we can see the output
        } // End MAIN
    } // End CLASS
} // End NAMESPACE
