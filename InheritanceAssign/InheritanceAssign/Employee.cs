// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 5: Inheritance Assignment
// AUTHOR: Steven Partlow
// DATE: 09/01/2023

// EMPLOYEE CLASS DEFINITION

// 3) Create another class called Employee and have it inherit from the Person class. Give the Employee class a property called Id and have it be of data type int. - DONE

namespace InheritanceAssign
{
    // GOAL 3) Create another class called Employee and have it inherit from the Person class. Give the Employee class a property called Id and have it be of data type int

    class Employee : Person // A class definition which represents an Employee object, which inherits from the Person Class
    {
        public int Id { get; set; } // A integer to represent an employee's id
    } // End Employee CLASS

} // End InheritanceAssign NAMESPACE
