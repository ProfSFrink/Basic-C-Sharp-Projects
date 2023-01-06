// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 4: Classes and Methods Assignment 3
// AUTHOR: Steven Partlow
// DATE: 06/01/2023

// GOALS
// 1) Create a class. In that class, create a void method that takes two integers as parameters. Have the method do a math operation on the first integer and display the second integer to the screen. - DONE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Meth_Ass_3
{
    class Class_Meth_Ass_3
    {
        public static void mathMethod(int firstParam, int secondParam) // Create a custom method, the void keyword signifies that this method does not return a value, the method has two parameters both integer values
        {
            // GOAL 1) Create a class. In that class, create a void method that takes two integers as parameters. Have the method do a math operation on the first integer and display the second integer to the screen.

            /* Take first parameter userNum1 multiply it by 30 then take the result of that and divide it by the value of userNum1 and display the result */
            Console.WriteLine("\n" + firstParam + " * 30 / " + firstParam + " = " + ( (firstParam*30) / firstParam) );

            Console.WriteLine("\nThe second variable passed into this method was " + secondParam); // Display the value of the second parameter to the console

        } // End mathMethod Method
    } // End Class_Meth_Ass_3 CLASS

} // End NAMESPACE
