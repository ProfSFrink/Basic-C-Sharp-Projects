// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 5: Interfaces Assignment
// AUTHOR: Steven Partlow
// DATE: 11/01/2023

// GOALS

// 1) Create an interface called IQuittable and have it define a void method called Quit(). - DONE
// 2) Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose. - DONE
// 3) Use polymorphism to create an object of type IQuittable and call the Quit() method on it. Hint: an object can be of an interface type if it implements that specific interface. - DONE

using System;

namespace Interfaces_Assign
{
    class Program
    {
      
        static void Main()
        {

            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Interfaces Assignment");
            Console.WriteLine("---------------------\n");

            // GOAL 3) Use polymorphism to create an object of type IQuittable and call the Quit() method on it. Hint: an object can be of an interface type if it implements that specific interface

            IQuittable employee = new Employee(); // Create an instance of the IQuittable interface using polymorphism to include the employee class

            employee.Quit(); // Execute the Quit() method

            Console.ReadLine(); // Pause the application

        } // End MAIN

    } // End CLASS

} // End NAMESPACE
