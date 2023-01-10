// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 5: Abstract Classes Assignment
// AUTHOR: Steven Partlow
// DATE: 10/01/2023

// PERSON CLASS DEFINITION

// GOALS

// 1) Create an abstract class called Person with two properties: string firstName and string lastName. - DONE
// 2) Give it the method SayName(). - DONE

using System;

namespace Abstract_Classes_Assign
{
    abstract class Person // Create a definition for an abstract class called Person, THIS CLASS CAN ONLY BE INHERITED NOT INSTANTIATED
    {
        /* PROPERTIES */

        // GOAL 1) Create an abstract class called Person with two properties: string firstName and string lastName

        public string firstName { get; set; } // Define a string data type called firstName
        public string lastName { get; set; } // Define a string data type called lastName

        /* METHODS */

        // GOAL 2) Give it the method SayName()

        public abstract void SayName(); // Create an abstract method called SayName, THIS METHOD MUST BE IMPLEMENTED BY ANY INHERITING CLASS

    } // End Person CLASS Definition

} // End Abstract_Classes_Assign NAMESPACE
