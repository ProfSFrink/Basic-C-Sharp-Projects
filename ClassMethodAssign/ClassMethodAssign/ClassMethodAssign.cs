// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 4: Class Method Assignment
// AUTHOR: Steven Partlow
// DATE: 07/01/2023

// GOAL
// 1) Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2. - DONE
// 4) Create a method with output parameters. - DONE
// 5) Overload a method. - DONE
// 6) Declare a class to be static. - DONE

namespace ClassMethodAssign
{
    // GOAL 6) Declare a class to be static

    static class ClassMethodAssign
    {
        // GOAL 1) Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2

        // GOAL 4) Create a method with output parameters

        public static void divideMethod(int userNum, out int outAnswer) // Define a class method called divideMethod with one input parameter, an integer called userNum, then an output parameter called outAnswer also an integer
        {
            outAnswer = userNum / 2; // Take the value of userNum and divide it by two, then assign the result to outAnswer
        } // End divideMethod Method

        // GOAL 5) Overload a method
        
        // GOAL 6) Declare a class to be static

        public static void divideMethod(int userNum, out int outAnswer, int optMultiplier = 1) // Overload the class method called divideMethod with one input parameter, an integer called userNum, then an output parameter called outAnswer also an integer then in addition an optional parameter to multiply the answer, set to one by default
        {
            outAnswer = userNum / 2 * optMultiplier; // Take the value of userNum divide by two and then multiply by the value of optMultipler, store the result within outAnswer 
        } // End overloaded divideMethod Method

    } // End ClassMethodAssign CLASS

} // End NAMESPCE (End of Class Definition)
