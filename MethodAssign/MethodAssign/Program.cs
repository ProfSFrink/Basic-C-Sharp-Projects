// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 3: Method Assignment
// AUTHOR: Steven Partlow
// DATE: 04/01/2023

// GOALS
// 1) Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer. The methods should do some math operation on the received parameter. Put this class in a separate .cs file in the application. - DONE
// 2) In the Main() program, ask the user what number they want to do the math operations on. - DONE
// 3) Call each method in turn, passing the user input to the method. Display the returned integer to the screen. - DONE 

using System;

namespace MethodAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Method Assignment");
            Console.WriteLine("-----------------");

            // GOAL 2) In the Main() program, ask the user what number they want to do the math operations on
            Console.Write("\nPlease enter a number: "); // Output this text to the console
            int userNum = Convert.ToInt32(Console.ReadLine()); // Cast the user input to the double variable userNum

            // GOAL 3) Call each method in turn, passing the user input to the method. Display the returned integer to the screen

            // METHOD 1) Multiply the user input by ten
            Console.WriteLine("\nThe number you have entered multiplied by ten is: " + Convert.ToString(MethodClass.multiplyByTen(userNum))); // Execute the multiplyByTen method passing in userNum then concatenating the returned result to the above string

            // METHOD 2) Calculate the square root
            Console.WriteLine("\nThe square root of the number you entered is: " + Convert.ToString(MethodClass.squareRoot(userNum))); // Execute the squareRoot method passing in userNum then concatenating the returned result to the above string

            // METHOD 3) Mutiply by one-hundred and twenty-five and divide the result by two
            Console.WriteLine("\nThe number you entered mutiplied by one-hundred and twenty-five then divided by two is: " + Convert.ToString(MethodClass.multiplyAndDivide(userNum))); // Execute the multiplyAndDivide method passing in userNum then concatenating the returned result to the above string

            Console.WriteLine("\nPlease press ENTER to quit the application");
            Console.ReadLine(); // Pause the application
        } // End MAIN

    } // End CLASS

} // End NAMESPACE
