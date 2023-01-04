// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 3: Method Assignment
// AUTHOR: Steven Partlow
// DATE: 04/01/2023

// GOALS
// 1) Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer. The methods should do some math operation on the received parameter. Put this class in a separate .cs file in the application. - DONE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssign
{
    class MethodClass
    {
        public static double multiplyByTen(double userNum)
        {
            return userNum * 10; // Take the input parameter userNum multiply it by ten and return the result to the main program
        } // End multiplyByTen Method

        public static double squareRoot(double userNum)
        {
            return Math.Sqrt(userNum); // Calculate the square root of the input parameter userNum
        } // End squareRoot Method

        public static double multiplyAndDivide(double userNum)
        {
            return (userNum * 125) / 2; // Multiply the input parameter userNum by 125 and divide the result of that by 2
        } // End multiplyAndDivide Method

    } // End CLASS

} // End NAMESPACE
