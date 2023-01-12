// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 6: Generics Assignment
// AUTHOR: Steven Partlow
// DATE: 12/01/2023

// PERSON CLASS DEFINITION

namespace Generics_Assign
{

    abstract class Person // Create a definition for an abstract class called Person, THIS CLASS CAN ONLY BE INHERITED NOT INSTANTIATED
    {
        /* PROPERTIES */

        public string firstName { get; set; } // Define a string data type called firstName
        public string lastName { get; set; } // Define a string data type called lastName

        /* METHODS */

        public abstract void ShowThings(); // Create an abstract method called ShowThings, THIS METHOD MUST BE IMPLEMENTED BY ANY INHERITING CLASS

    } // End Person CLASS Definition

} // End Generics_Assign NAMESPACE

