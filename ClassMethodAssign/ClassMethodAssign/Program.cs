// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 4: Class Method Assignment
// AUTHOR: Steven Partlow
// DATE: 07/01/2023

// GOAL
// 1) Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.
// 2) In the Main() method, instantiate that class. - DONE
// 3) Have the user enter a number. Call the method on that number. Display the output to the screen. It should be the entered number, divided by two. - DONE
// 4) Create a method with output parameters. - DONE
// 5) Overload a method. - DONE
// 6) Declare a class to be static. - DONE

using System;

namespace ClassMethodAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Classes Method Assignment");
            Console.WriteLine("-------------------------");

            // GOAL 3) Have the user enter a number. Call the method on that number. Display the output to the screen. It should be the entered number, divided by two

            Console.Write("\nPlease enter a whole number: "); // Output this text to the console
            int userInput = Convert.ToInt32(Console.ReadLine()); // Cast the input to the integer variable userInput

            int answer; // Create an integer variable called answer

            Console.Write("\nEnter an optional multiplier, defaults to one if nothing is entered: ");
            string multipler = Console.ReadLine(); // Take the user input and assign it to the string variable mutliplier

            if (multipler == "") // If the mutliplier string contains nothing at all then
            {
                ClassMethodAssign.divideMethod(userNum: userInput, outAnswer: out answer); // Execute the divideMethod method from our ClassMethodAssign object and pass in the userInput integer then store the outputted answer in the integer answer
                Console.WriteLine("\nThe number you have entered " + userInput + " divided by 2 is: " + answer); // Concatenate this string and output it to the console
            } // End IF

            // GOAL 5) Overload a method
            else // If the user did enter a value then
            {
                ClassMethodAssign.divideMethod(userNum: userInput, outAnswer: out answer, optMultiplier: Convert.ToInt32(multipler)); // Execute the divideMethod method from our ClassMethodAssign object and pass in the userInput integer then store the outputted answer in the integer answer then cast the value of multiplier to an integer then pass that in to overload the divideMethod method
                Console.WriteLine("\nThe number you have entered " + userInput + " divided by 2 then multiplied by " + multipler + " is: " + answer); // Concatenate this string and output it to the console
            } // End ELSE


            Console.ReadLine(); // Pause the application
        } // End MAIN

    } // End CLASS

} // End NAMESPCE (End of MAIN Program)
