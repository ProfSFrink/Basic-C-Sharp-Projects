// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 5: Operator Overloading Assignment
// AUTHOR: Steven Partlow
// DATE: 13/01/2023

// PERSON CLASS DEFINITION

namespace Overload_Op_Assign
{
    
    abstract class Person // Create a definition for an abstract class called Person, THIS CLASS CAN ONLY BE INHERITED NOT INSTANTIATED
    {
        /* PROPERTIES */

        public string firstName { get; set; } // Define a string data type called firstName
        public string lastName { get; set; } // Define a string data type called lastName

        /* METHODS */

        public abstract void SayName(); // Create an abstract method called SayName, THIS METHOD MUST BE IMPLEMENTED BY ANY INHERITING CLASS

    } // End Person CLASS Definition

} // End Overload_Op_Assign NAMESPACE
