// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 4: Classes and Methods Assignment 1
// AUTHOR: Steven Partlow
// DATE: 05/01/2023

// GOALS

// 1) Create a class. In that class, create a method that will take in an integer, create a math operation for this integer (addition, subtraction, etc.), then return the answer as an integer.
// 2) In the Main() method of the console app, instantiate the class and call the one method, passing in an integer. Display the result to the screen. - DONE
// 3) Add a second method to the class with the same name that will take in a decimal, create a different math operation for it, then return the answer as an integer. - DONE
// 4) In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen. - DONE
// 5) Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it, then return the answer as an integer. - DONE
// 6) In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer. Display the result to the screen. - DONE

using System;

namespace Class_Meth_Ass_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Classes and Methods Assignment 1");
            Console.WriteLine("--------------------------------");

            // GOAL 2) In the Main() method of the console app, instantiate the class and call the one method, passing in an integer. Display the result to the screen

            Console.Write("\nPlease enter a whole number: "); // Output this text to the console
            int userNum1 = Convert.ToInt32(Console.ReadLine()); // Cast the input to an integer and assign it to userNum1

            int answer = Class_Meth_Ass_1.mathMethod(userNum1); // Pass the value of userNum1 into the mathMethod method of the Class_Meth_Ass_1 class and assign the output to the answer integer variable
            Console.WriteLine("The number you have entered, multiplied by 27 is: {0}", answer); // Concatenate this string and output the result to the console

            // GOAL 4) In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen
            
            Console.Write("\nPlease enter a number: "); // Output this text to the console
            decimal userNum2 = Convert.ToInt32(Console.ReadLine()); // Cast the input to an integer and assign it to userNum1

            answer = Class_Meth_Ass_1.mathMethod(userNum2); // Pass the value of userNum2 into the mathMethod method of the Class_Meth_Ass_1 class assign the output to the integer variable answer
            Console.WriteLine("The number you have entered, multiplied by 8 then divided by 2 is: {0}", answer); // Concatenate this string and output the result to the console

            // GOAL 6) In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer. Display the result to the screen

            Console.Write("\nPlease enter a whole number: "); // Output this text to the console
            string userNum3 = Console.ReadLine(); // Take the user input and assign it to the string variable userNum3

            answer = Class_Meth_Ass_1.mathMethod(userNum3); // Pass the value of userNum3 into the mathMethod method of the Class_Meth_Ass_1 class assign the output to the integer varibale answer
            Console.WriteLine("\nThe answer is {0}", answer); // Concatenate this string and output the result to the console

            Console.ReadLine(); // Pause the application
        } // End MAIN

    } // End CLASS

} // End NAMESPACE
