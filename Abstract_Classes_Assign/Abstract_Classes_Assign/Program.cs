// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 5: Abstract Classes Assignment
// AUTHOR: Steven Partlow
// DATE: 10/01/2023

// GOALS

// 1) Create an abstract class called Person with two properties: string firstName and string lastName. - DONE
// 2) Give it the method SayName(). - DONE
// 3) Create another class called Employee and have it inherit from the Person class. - DONE
// 4) Implement the SayName() method inside of the Employee class.
// 5) Inside the Main() method, instantiate an Employee object with firstName "Sample" and lastName "Student". Call the SayName() method on the object. - DONE

using System;

namespace Abstract_Classes_Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Abstract Classes Assignment");
            Console.WriteLine("---------------------------\n");

            // GOAL 5) Inside the Main() method, instantiate an Employee object with firstName "Sample" and lastName "Student". Call the SayName() method on the object

            // Instantiate a new instant of the Employee object called employee, assigning values to the firstName and lastName properties
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" }; 
            employee.SayName(); // Execute the employee object built-in method SayName();

        } // End MAIN

    } // End PROGRAM

} // End NAMESPACE
