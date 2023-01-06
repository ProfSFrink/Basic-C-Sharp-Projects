// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 4: Classes and Methods Assignment 1
// AUTHOR: Steven Partlow
// DATE: 05/01/2023

// GOALS
// 1) Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional. Have the method do a math operation and return an integer result. - DONE

namespace Class_Meth_Ass_2
{
    class Class_Meth_Ass_2 // Create a class called Class_Meth_Ass_2
    {
        /* A custom method which has two parameters, the first is a integer called userNum1, the second is an optional parameter which defaults to 1 if nothing is passed in */
        public static int mathMethod(int userNum1, int userNum2 = 1)
        {
            return (userNum1 * userNum2) * userNum2; // Take UserNum1 multiply it by userNum2 then multiply the result of that by userNum2 and return the result to the main program
        } // End mathMethod Method

    } // End Class_Meth_Ass_2 CLASS

} // End NAMESPACE
