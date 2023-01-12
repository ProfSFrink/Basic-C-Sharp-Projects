// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 5: Generics Assignment
// AUTHOR: Steven Partlow
// DATE: 12/01/2023

// GOALS

// 1) Make the Employee class take a generic type parameter. - DONE
// 2) Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class. - DONE
// 3) Instantiate an Employee object with type "string" as its generic parameter. Assign a list of strings as the property value of Things. - DONE
// 4) Instantiate an Employee object with type "int" as its generic parameter. Assign a list of integers as the property value of Things. - DONE
// 5) Create a loop that prints all of the Things to the Console. - DONE 

using System;
using System.Collections.Generic; // This allows the use of List objects

namespace Generics_Assign
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Output all the below text to the console
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Generics Assignment");
            Console.WriteLine("-------------------\n");

            // GOAL 3) Instantiate an Employee object with type "string" as its generic parameter. Assign a list of strings as the property value of Things

            Employee<string> employees = new Employee<string>(); // Instantiate a new instance of the Employee class passing in string as a data type and call it employees
            employees.Things = new List<string>(); // Set the Things property as list of strings

            // Add these values to the employees object
            employees.Things.Add("Steven Partlow");
            employees.Things.Add("Emma Partlow");
            employees.Things.Add("Keith Partlow");
            employees.Things.Add("Chris Partlow");

            // GOAL 4) Instantiate an Employee object with type "int" as its generic parameter. Assign a list of integers as the property value of Things

            Employee<int> employeeID = new Employee<int>(); // Instantiate a new instance of the Employee class passing in integer as a data type and call it employeeID
            employeeID.Things = new List<int>(); // Set the Things property as list of integers

            // Add these values to the employeeID object
            employeeID.Things.Add(689214);
            employeeID.Things.Add(843568);
            employeeID.Things.Add(539587);
            employeeID.Things.Add(601666);

            // GOAL 5) Create a loop that prints all of the Things to the Console

            employees.ShowThings(); // Execute the built-in method ShowThings() of the employees object
            employeeID.ShowThings(); // Execute the built-in method ShowThings() of the employeeID object 

            Console.ReadLine(); // Pause the application
        } // End MAIN

    } // End CLASS

} // End Generics_Assign NAMESPACE
