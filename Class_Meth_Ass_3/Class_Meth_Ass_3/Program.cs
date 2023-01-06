// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 4: Classes and Methods Assignment 3
// AUTHOR: Steven Partlow
// DATE: 06/01/2023

// GOALS
// 1) Create a class. In that class, create a void method that takes two integers as parameters. Have the method do a math operation on the first integer and display the second integer to the screen. - DONE
// 2) In the Main() method of the console app, instantiate the class. - DONE
// 3) Call the method in the class, passing in two numbers. - DONE
// 4) Call the method in the class, specifying the parameters by name. - DONE

using System;

namespace Class_Meth_Ass_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Classes and Methods Assignment 3");
            Console.WriteLine("--------------------------------");

            Console.Write("Please enter a whole number, thank you: "); // Output this text to the console
            int userNum1 = Convert.ToInt32(Console.ReadLine()); // Cast the user input to an integer and store the value in userNum1

            Console.Write("Please enter a whole number, thank you: "); // Output this text to the console
            int userNum2 = Convert.ToInt32(Console.ReadLine()); // Cast the user input to an integer and store the value in userNum2

            // GOAL 2) In the Main() method of the console app, instantiate the class
            // GOAL 3) Call the method in the class, passing in two numbers

            Class_Meth_Ass_3.mathMethod(userNum1, userNum2); // Instantiate an instance of the class Class_Meth_Ass_3, the execute the method mathMethod and pass in the values of userNum1 and userNum2

            // GOAL 4) Call the method in the class, specifying the parameters by name

            Class_Meth_Ass_3.mathMethod(firstParam: userNum1, secondParam: userNum2); // Instantiate an instance of the class Class_Meth_Ass_3, the execute the method mathMethod and pass in the value userNum1 with the parameter name firstParam, then pass in userNum2 with the paramter name secondParam, these names match the names of these paramters in the class definition

            Console.ReadLine(); // Pause the application
        } // End MAIN

    } // End CLASS

} // End NAMESPACE
