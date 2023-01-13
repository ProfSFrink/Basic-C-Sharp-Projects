// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 5: Operator Overloading Assignment
// AUTHOR: Steven Partlow
// DATE: 13/01/2023

// GOALS

// 1) Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property. - DONE

using System;


namespace Overload_Op_Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output all the below text to the console
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Operator Overloading Assignment");
            Console.WriteLine("-------------------------------\n");

            /* Instantiate three instances of the Employee class and assign values to the firstName, lastName and Id properties */
            Employee employee_1 = new Employee() { firstName = "Steven", lastName = "Partlow", Id = 687294 };
            Employee employee_2 = new Employee() { firstName = "Gavin", lastName = "Cook", Id = 687294 };
            Employee employee_3 = new Employee() { firstName = "Jason", lastName = "Young", Id = 539587 };

            /* COMPARE EMPLOYEE 1 AND 2 */

            Console.WriteLine("NAME: " + employee_1.firstName + " " + employee_1.lastName + " EMPLOYEE ID: " + employee_1.Id); // Concatenate this string and output it to the console
            Console.WriteLine("NAME: " + employee_2.firstName + " " + employee_2.lastName + " EMPLOYEE ID: " + employee_2.Id); // Concatenate this string and output it to the console

            Console.WriteLine("\nDo the IDs of these two employees match: " + Convert.ToBoolean(employee_1 == employee_2)); // Utilise our overloaded == operator to test if the two employee objects Id proeprties match and output the result to the console

            /* COMPARE EMPLOYEE 1 AND 3 */

            Console.WriteLine("\nNAME: " + employee_1.firstName + " " + employee_1.lastName + " EMPLOYEE ID: " + employee_1.Id); // Concatenate this string and output it to the console
            Console.WriteLine("NAME: " + employee_3.firstName + " " + employee_3.lastName + " EMPLOYEE ID: " + employee_3.Id); // Concatenate this string and output it to the console
            
            Console.WriteLine("\nDo the IDs of these two employees match: " + Convert.ToBoolean(employee_1 == employee_3)); // Utilise our overloaded == operator to test if the two employee objects Id proeprties match and output the result to the console

            Console.ReadLine(); // Pause the application
        } // End MAIN

    } // End CLASS

} // End Overload_Op_Assign
