// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 3: Exception Handling Tutorial
// AUTHOR: Steven Partlow
// DATE: 01/01/2023

using System;

class Program
    {
        static void Main()
        {

        try
        {
            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");

            Console.Write("Pick a number: "); // Output this text to the console
            int numberOne = Convert.ToInt32(Console.ReadLine()); // Take the user input and cast it to the integer value numberOne

            Console.Write("Pick a second number: "); // Output this text to the console
            int numberTwo = Convert.ToInt32(Console.ReadLine()); // Take the user input and cast it to the integer value numberTwo

            Console.WriteLine("Dividing the two..."); // Output this text to the console
            int numberThree = numberOne / numberTwo; // Divide numberOne by numberTwo then store the result within numberThree
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree); // Concatenate these values into this string and then output it to the console

        } // End TRY

        catch (FormatException ex) // This block only executes if a FormatException occurs, which is when the user enters a letter or special character instead of a numeric value, when an error does occur the error is stored within the variable ex
        {
            Console.WriteLine("\nPlease type a whole number."); // Inform the user they must enter a whole number
        } // End CATCH

        catch (DivideByZeroException ex) // This block only executes if a DivideByZeroException occurs, which is when the user attempts to divide a number by zero, when an error does occur the error is stored within the variable ex
        {
            Console.WriteLine("\nPlease don't divide by zero."); // Inform the user that they cannot divide by zero
        } // End CATCH

        catch (Exception ex) // This block executes if there is any other error that occurs that is not caught by the two above catch blocks, the nature of the error will be caught by the variable ex
        {
            Console.WriteLine("\n" + ex.Message); // Inform the user the nature of the error that has occured
        } // End CATCH

        finally
        {
            Console.ReadLine(); // Pause the application
        } // End FINALLY

    } // End MAIN

    } // End CLASS
