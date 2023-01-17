// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 5: Lambda Expressions Assignment
// AUTHOR: Steven Partlow
// DATE: 17/01/2023

// EMPLOYEE CLASS DEFINITION

using System;

namespace Lambda_Express_Assign
{

    class Employee : Person // Inherit the Person Class
    {

        /* PROPERTIES */

        public int Id { get; set; } // A integer to represent an employee's id

        /* METHODS */

        public override void SayName() // We utilise the override keyword to tell the compiler that we are overriding the inherited SayName() method with this version of the method
        {
            Console.WriteLine(firstName + " " + lastName); // Concatenate firstName and lastName into a single string and output to the console
            Console.ReadLine(); // Pause the application
        } // End SayName Method

    } // End Employee CLASS Definition

} // End Lambda_Express_Assign NAMESPACE
