// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 4: Classes and Methods Assignment 1
// AUTHOR: Steven Partlow
// DATE: 05/01/2023

// GOALS

// 1) Create a class. In that class, create a method that will take in an integer, create a math operation for this integer (addition, subtraction, etc.), then return the answer as an integer. - DONE
// 3) Add a second method to the class with the same name that will take in a decimal, create a different math operation for it, then return the answer as an integer.
// 5) Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it, then return the answer as an integer. - DONE

using System;

namespace Class_Meth_Ass_1
{
    class Class_Meth_Ass_1
    {
        // GOAL 1) Create a class. In that class, create a method that will take in an integer, create a math operation for this integer (addition, subtraction, etc.), then return the answer as an integer

        public static int mathMethod(int userNum)
        {
            return userNum * 27; // Take the input integer parameter userNum and multiply it by 27 then return the result
        } // End mathMethod METHOD

        // GOAL 3) Add a second method to the class with the same name that will take in a decimal, create a different math operation for it, then return the answer as an integer

        public static int mathMethod(decimal userNum) // Take the input decimal parameter userNum and multiply it by eight and divide the result of that by two then cast the result back to an integer and return the result to the main program
        {
            return Convert.ToInt32((userNum * 8) / 2); // Take decimal input parameter value userNum multiple it by eight and divide the result of that by two then return the result to the main program 
        } // End mathMethod METHOD

        // GOAL 5) Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it, then return the answer as an integer

        public static int mathMethod(string userNum)
        {
            return Convert.ToInt32( mathMethod( Convert.ToInt32(userNum) ) + mathMethod( Convert.ToDecimal(userNum) ) ); // Take the value of userNum pass it into the first instance of the mathMethod method as an integer then pass in the value of userNum to the second instance of the mathMethod method as a decimal then add the result of both together, then cast the result to an integer and return the result to the main program
        } // End mathMethod METHOD

    } // End CLASS

} // End NAMESPACE
