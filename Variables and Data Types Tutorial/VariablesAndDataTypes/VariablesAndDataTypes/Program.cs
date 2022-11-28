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
            /* Variables and Data Types Tutorial - Part 1 */

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

            bool isStudying = false; // Can be either TRUE or FALSE
            byte hoursWorked = 42; // Integer between 0 and 255

            /* Variables and Data Types Tutorial - Part 2 */

            sbyte currentTemperature = -23; // Integer between -128 and 127
            char questionMark = '\u2753'; // UNICODE Character for '?', char store one UNICODE character which is 2 bytes, char's must be within single-quotation marks

            Console.WriteLine(questionMark); // Print 'questionMark' to the display
            Console.ReadLine(); // This is to pause the program so we can see the above output

            decimal moneyInBank = 100.5m; // 'decimal' is for values representing money the 'm' is to tell the C# compiler that the value is a decimal data type
            double heightInCentimeters = 211.30202092; // Integer value 15 or 16 digits in length
            float secondsLeft = 2.62f; // Represents any number up to 7 digits in length the 'f' is tell the C# compiler that the value is a float data type
            short temperatureOnMars = -341; // Represents a whole number -32,768 and 32,767
            string myName = "Jesse"; // Represents 0 or more UNICODE characters, strings must be within double-quotation marks

            int currentAge = 30; // Create an integer with a value of 30
            string yearsOld = currentAge.ToString(); // Convert integer 'currentAge' to string 'yearsOld'

            bool isRaining = true; // Create a boolean value 'isRaining' and set it to true
            string rainingStatus = Convert.ToString(isRaining); // Convert boolean 'isRaining' to string 'rainingStatus'

            Console.WriteLine(rainingStatus); // Print 'rainingStatus' to the display
            Console.ReadLine(); // This is to pause the program so we can see the above output
        } // End Main
    } // End Class
} // End Namespace
