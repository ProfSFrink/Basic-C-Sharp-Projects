// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 6: Generics Assignment
// AUTHOR: Steven Partlow
// DATE: 12/01/2023

// EMPLOYEE CLASS DEFINITION

// GOALS

// 1) Make the Employee class take a generic type parameter. - DONE
// 2) Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class. - DONE
// 5) Create a loop that prints all of the Things to the Console. - DONE

using System;
using System.Collections.Generic; // This allows the use of List objects

namespace Generics_Assign
{
    // GOAL 1) Make the Employee class take a generic type parameter

    class Employee<T> : Person // Add the <T> parameter which determines the data type of properties of the class also inherits the Person Class
    {
        /* PROPERTIES */

        // GOAL 2) Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class

        public List<T> Things { get; set; } // Create a list of data type <T>, the parameter passed in at class instantiation which determines the data type of the list elements

        /* METHODS */

        // 5) Create a loop that prints all of the Things to the Console

        public override void ShowThings() // We utilise the override keyword to tell the compiler that we are overriding the inherited ShowThings() method with this version of the method
        {
            foreach (T Thing in Things) // Iterate through this objects Things property which will be a list of data type <T>
            {
                Console.WriteLine(Thing); // Output the current value of Thing to the console
            } // End FOREACH

            Console.Write("\n"); // Output an empty line to the console

        } // End SayName Method

    } // End Employee CLASS Definition

} // End Generics_Assign NAMESPACE
