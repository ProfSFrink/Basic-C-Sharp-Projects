// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 5: Abstract Classes Assignment
// AUTHOR: Steven Partlow
// DATE: 10/01/2023

// EMPLOYEE CLASS DEFINITION

// GOALS

// 3) Create another class called Employee and have it inherit from the Person class. - DONE
// 4) Implement the SayName() method inside of the Employee class. - DONE

using System;

namespace Abstract_Classes_Assign
{
    // GOAL 3) Create another class called Employee and have it inherit from the Person class

    class Employee : Person // Inherit the Person class
    {
        // GOAL 4) Implement the SayName() method inside of the Employee class

        public override void SayName() // We utilise the override keyword to tell the compiler that we are overriding the inherited SayName() method with this version of the method
        {
            Console.WriteLine(firstName + " " + lastName); // Concatenate firstName and lastName into a single string and output to the console
            Console.ReadLine(); // Pause the application
        } // End SayName Method

    } // End Employee CLASS Definition

} // End NAMESPACE Abstract_Classes_Assign
