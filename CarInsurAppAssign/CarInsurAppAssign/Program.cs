// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 9: Boolean Logic Assignment - Car Insuranace Approval
// AUTHOR: Steven Partlow
// DATE: 05/12/2022
//
// GOALS
// 1) Ask the user "What is your age?" - DONE
// 2) Ask the user "Have you ever had a DUI (ANSWER: true or false (enter in lowercase)?" - DONE
// 3) Ask the user "How many speeding tickets have you had?" - DONE
// 4) Determine if the user qualifies for a driving license (CRITERIA: Over 15 years old, NO DUI's, no more than 3 speeding tickets - DONE
// 5) Display the result to user within the console window - DONE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurAppAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("CAR INSURANCE APPROVAL ASSIGNMENT");
            Console.WriteLine("---------------------------------\n");

            // 1) Ask the user "What is your age?"
            Console.Write("What is your age: "); // Print this text to the console
            int userAge = Convert.ToInt32(Console.ReadLine()); // Cast the user input from a string to an integer and store the result in userAge

            // 2) Ask the user "Have you ever had a DUI (ANSWER: true or false (enter in lowercase)?"
            Console.Write("Have you ever had a DUI (ANSWER: true or false (enter in lowercase)?: "); // Print this text to the console
            bool hadDUI = Convert.ToBoolean(Console.ReadLine()); // Cast the user input from a string to a boolean and store the result in hadDUI

            // 3) Ask the user "How many speeding tickets have you had?"
            Console.Write("How many speeding tickets have you had?: "); // Print this text to the console
            int speedingTickets = Convert.ToInt32(Console.ReadLine()); // Cast the user input from a string to an integer and store the result in speedingTickets 

            // 4) Determine if the user qualifies for a drving license (CRITERIA: Over 15 years old, NO DUI's, no more than 3 speeding tickets
            // 5) Display the result to user within the console window

            // We check if userAge is greater or equal to 15 AND hadDUI is false AND if speedingTickets is less or equal to 3 if all three of these condition are TRUE the
            // user qualifies for car insurance if any condition is false they do not. We then take the result of this boolean logic and concatenate it in uppercase to this string
            Console.WriteLine("\nDo you qualify for car insurance: " + Convert.ToString((userAge >= 15) && (hadDUI == false) && (speedingTickets <= 3)).ToUpper());
            
            Console.WriteLine("\nPress the ENTER key to exit the application"); // Output this text to the display
            Console.ReadLine(); // Pause the application so we can see the output

        } // End MAIN
    } // End CLASS

} // End NAMESPACE
