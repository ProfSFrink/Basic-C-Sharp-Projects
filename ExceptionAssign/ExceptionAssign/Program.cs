// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 3: Exception Assignment
// AUTHOR: Steven Partlow
// DATE: 02/01/2023


// GOALS
// 1) Create a list of integers. Ask the user for a number to divide each number in the list by. Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen. - DONE
// 2) Run the code, entering in non-zero numbers as the user. Look at the displayed results. - DONE
// 3) Run the code again, entering in zero as the number to divide by. Note any error messages you get. - DONE
// 4) Run the code once again, entering in a string as the number to divide by. Note any error messages you get. - DONE
// 5) Now put the loop in a try/catch block. Below and outside of the try/catch block, make the program print a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution. In the catch block, display the error message to the screen. Then try various combinations of user input: valid numbers, zero and a string. Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed. - DONE

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Output all the below text to the display
        Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
        Console.WriteLine("----------------------------------\n");
        Console.WriteLine("Exception Assignment");
        Console.WriteLine("--------------------");

        // GOAL 1) Create a list of integers. Ask the user for a number to divide each number in the list by. Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen

        Random rnd = new Random(); // Create a new instance of the random number object and call is rnd

        /* Create a new instance of the list object called ranNums then fill it with six integer values which are random numbers between 1 and 100 */
        List<int> ranNums = new List<int>() { rnd.Next(1, 101), rnd.Next(1, 101), rnd.Next(1, 101), rnd.Next(1, 101), rnd.Next(1, 101), rnd.Next(1, 101), };

        // GOAL 5) Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program print a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution.In the catch block, display the error message to the screen.Then try various combinations of user input: valid numbers, zero and a string.Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed

        try
        {
            Console.Write("The program has generated six random numbers which are "); // Output this text to the console

            foreach (int ranNum in ranNums) // Iterate through the list ranNums then assign the value within each element to ranNum
            {
                Console.Write(ranNum + " "); // Output the current value of ranNum then an empty space to the console
            } // End FOREACH

            Console.Write("\n\nPlease enter a number to divide each of the above numbers by: "); // Output the following text to the console
            int divisonNum = Convert.ToInt32(Console.ReadLine()); // Take the user input and cast to the integer value divisonNum

            Console.Write("\nThe six numbers divided by " + divisonNum + " are ");

            foreach (int ranNum in ranNums) // Iterate through the list ranNums then assign the value within each element to ranNum
            {
                Console.Write(ranNum / divisonNum + " "); // Divide the current value of ranNum by divisonNum and print the product to the console
            } // End FOREACH

        } // End TRY

        catch (DivideByZeroException ex) // This block only executes if a DivideByZeroException occurs, which is when the user attempts to divide a number by zero, when an error does occur the error is stored within the variable ex
        {
            Console.WriteLine("\n\n" + ex.Message); // Output the error message generated to the console
            Console.WriteLine("\nPlease don't divide by zero, you must enter a number of at least one or higher, Thank You!."); // Output this text to the console
        } // End CATCH

        catch (FormatException ex) // This block only executes if a FormatException occurs, which is when the user enters a letter or special character instead of a numeric value, when an error does occur the error is stored within the variable ex
        {
            Console.WriteLine("\n" + ex.Message); // Output the error message generated to the console
            Console.WriteLine("\nPlease don't type letters or special characters, you must enter a number of at least one or higher, Thank You!."); // Inform the user they must enter a whole number
        } // End CATCH

        finally // This code is always executed after the try / catch block has been executed
        {
            Console.WriteLine("\nThe program has emerged from the try / catch block successfully. Normal program execution has now resumed!.");
        } // END FINALLY

        Console.WriteLine("\nPress the ENTER key to exit the application.");
        Console.ReadLine(); // Pause the Application

        // THIS IS THE RESULT OF GOALS 2 THROUGH 4 AND WHAT OCCURED IN THE PROGRAM BEFORE THE TRY / CATCH BLOCK WAS IMPLEMENTED, I HAVE RECORDED THE RANDOM NUMBERS GENERATED BY THE APPLICATION AND THE INPUT I PUT IN TO THE PROGRAM A LONG WITH A LOG OF THE ERROR VISUAL STUDIO GAVE

        // GOAL 2) Run the code, entering in non-zero numbers as the user. Look at the displayed results

        // EXAMPLE RESULT 1:
        //
        // RANDOM NUMBERS GENERATED: 44 31 52 97 38 66
        // USER DIVISOR: 3
        // RESULT: 14 10 17 32 12 22

        // EXAMPLE RESULT 2:
        //
        // RANDOM NUMBERS GENERATED: 34 54 96 71 25 71
        // USER DIVISOR: 5
        // RESULT: 6 10 19 14 5 14

        // EXAMPLE RESULT 3:
        //
        // RANDOM NUMBERS GENERATED: 49 61 39 3 7 26
        // USER DIVISOR: 8
        // RESULT: 6 7 4 0 0 3

        // GOAL 3) Run the code again, entering in zero as the number to divide by. Note any error messages you get
        //
        // EXAMPLE RESULT:
        // RANDOM NUMBERS GENERATED: 47 100 27 42 1 6
        // USER DIVISOR: 0
        // RESULT: The error message shown below as the user has attempted to divide by zero

        /* System.DivideByZeroException
           HResult = 0x80020012
           Message = Attempted to divide by zero.
           Source = ExceptionAssign
           StackTrace:
           at Program.Main(String[] args) in C: \Users\ProfS\OneDrive\Personal\Learning\Pitman\10.C# and .NET Framework - Part 2\Basic-C-Sharp-Programs\ExceptionAssign\ExceptionAssign\Program.cs:line 51 */

        // GOAL 4) Run the code once again, entering in a string as the number to divide by. Note any error messages you get
        //
        // EXAMPLE RESULT:
        // RANDOM NUMBERS GENERATED: 32 32 49 38 85 88
        // USER DIVISOR: seven
        // RESULT: The error message shown below as the user has entered the string seven instead of the number 7

        /* System.FormatException
           HResult=0x80131537
           Message=Input string was not in a correct format.
           Source=mscorlib
           StackTrace:
           at System.Number.StringToNumber(String str, NumberStyles options, NumberBuffer& number, NumberFormatInfo info, Boolean parseDecimal)
           at System.Number.ParseInt32(String s, NumberStyles style, NumberFormatInfo info)
           at System.Convert.ToInt32(String value)
           at Program.Main(String[] args) in C:\Users\ProfS\OneDrive\Personal\Learning\Pitman\10. C# and .NET Framework - Part 2\Basic-C-Sharp-Programs\ExceptionAssign\ExceptionAssign\Program.cs:line 45 */

    } // End Main

} // End CLASS

