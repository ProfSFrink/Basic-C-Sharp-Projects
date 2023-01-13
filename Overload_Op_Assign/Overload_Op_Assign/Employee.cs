// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 5: Operator Overloading Assignment
// AUTHOR: Steven Partlow
// DATE: 13/01/2023

// EMPLOYEE CLASS DEFINITION

// GOALS

// 1) Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property. - DONE

using System;

namespace Overload_Op_Assign
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

        // GOAL 1) Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property

        public static bool operator ==(Employee employee_1, Employee employee_2) // Overload the == operator, taking two instances of the Employee object as parameters
        {
            return employee_1.Id == employee_2.Id; // Compare the id properties of the two employee objects, if they are equal return true
        } // End == operator overload Method

        public static bool operator !=(Employee employee_1, Employee employee_2) // Overload the != operator, taking two instances of the Employee object as parameters
        {
            return employee_1.Id != employee_2.Id; // Compare the id properties of the two employee objects, if they are NOT equal return true
        } // End != overload Method

        public override bool Equals(object obj) // Overide the Equals method, with an object passed in as a parameter
        {
            var employee = obj as Employee; // Assign the object passed as instance of the Employee class, then assign this to the variable employee

            if (employee == null) // If the employee object is empty return false
                return false;

            return this.Id.Equals(employee.Id); // Check this instance of the Employee object Id property with the Id property of the Employee instance passed in, return true if they match
        } // End Equals override Method

        public override int GetHashCode() // Override the GetHashCode()
        {
            return 0; // Return zero
        } // ENd GetHashCode() override

    } // End Employee CLASS Definition

} // End Overload_Op_Assign NAMESPACE
