// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 5: Inheritance Assignment
// AUTHOR: Steven Partlow
// DATE: 09/01/2023

// GOALS
// 1) Create a class called Person and give it two properties, each of data type string. One called FirstName, the other LastName.
// 2) Give this class a void method called SayName() that takes no parameters and simply writes the person's full name to the console in the format of: "Name: [full name]".
// 3) Create another class called Employee and have it inherit from the Person class. Give the Employee class a property called Id and have it be of data type int. - DONE
// 4) Inside of the Main method, instantiate and initialize an Employee object with a first name of "Sample" and a last name of "Student". - DONE
// 5) Call the superclass method SayName() on the Employee object. - DONE


using System;

namespace InheritanceAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output all the below text to the display
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Inheritance Assignment");
            Console.WriteLine("----------------------\n");

            // GOAL 4) Inside of the Main method, instantiate and initialize an Employee object with a first name of "Sample" and a last name of "Student"

            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" }; // Instantiate a new instance of the Employee class and set the FirstName and LastName to these values

            // GOAL 5) Call the superclass method SayName() on the Employee object

            employee.SayName(); // Execute the SayName method of the Employee object
            Console.ReadLine(); // Pause the application
        } // End MAIN Program

    } // End CLASS

} // End NAMESPACE

