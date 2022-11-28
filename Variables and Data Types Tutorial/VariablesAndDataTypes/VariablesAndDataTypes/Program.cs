// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 4: Variables and Data Types Tutorial
// AUTHOR: Steven Partlow
// DATE: 28/11/2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?"); // Ask the user to enter their name
            string yourName = Console.ReadLine(); // Store the value entered to the string variable 'yourName'
            Console.WriteLine("Your name is: " + yourName); // Through use of string concatenation print the value of 'yourName'
            Console.ReadLine(); // This is to pause the program so we can see the above output

            Console.WriteLine("What is your favorite number?"); // Ask the user to enter their number
            string favoriteNumber = Console.ReadLine(); // Store the value entered to the string variable 'favoriteNumber'
            int favNum = Convert.ToInt32(favoriteNumber); // Convert the string variable 'favoriteNumber' to integer 'favNum'
            int total = favNum + 5; // Take the value of 'favNum' and add 5 to it then store the result in 'total'
            Console.WriteLine("Your favorite number + 5 is: " + total); // Through use of string concatenation print the value of 'total'
            Console.ReadLine(); // This is to pause the program so we can see the above output
        } // End Main
    } // End Class
} // End Namespace
