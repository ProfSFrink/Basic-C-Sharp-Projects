// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 5: Interfaces Assignment
// AUTHOR: Steven Partlow
// DATE: 11/01/2023

// EMPLOYEE CLASS DEFINITION

// GOALS

// 2) Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose. - DONE

using System;

namespace Interfaces_Assign
{
    // GOAL 2) Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.

    class Employee : Person, IQuittable // Inherit the Person Class and the Interface IQuittable
    {
 
        public override void SayName() // We utilise the override keyword to tell the compiler that we are overriding the inherited SayName() method with this version of the method
        {
            Console.WriteLine(firstName + " " + lastName); // Concatenate firstName and lastName into a single string and output to the console
            Console.ReadLine(); // Pause the application
        } // End SayName Method

        public void Quit() // We have to implement this method here as it is part of the inherited interface IQuittable
        {
            Console.WriteLine("This method Quit() is inherited from the IQuittable interface!."); // Output this text to the console
            Console.ReadLine(); // Pause the application
        } // End Quit Method

    } // End Employee CLASS Definition

} // End Interfaces_Assign NAMESPACE
