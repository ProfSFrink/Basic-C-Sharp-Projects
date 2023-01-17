// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 6: Structs Assignment
// AUTHOR: Steven Partlow
// DATE: 17/01/2023

// GOALS

// 1) In the Main() method, create a list of at least 10 employees. Each employee should have a first and last name, as well as an Id. At least two employees should have the first name "Joe". - DONE
// 2) Using a foreach loop, create a new list of all employees with the first name "Joe". - DONE
// 3) Perform the same action again, but this time with a lambda expression. - DONE
// 4) Using a lambda expression, make a list of all employees with an Id number greater than 5. - DONE

using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Express_Assign
{

    class Program
    {

        static void Main(string[] args)
        {
            /* Lists to generate our employee objects */

            /* Instantiate a list of strings called firstName and add 10 values to the list */
            List<string> firstNames = new List<string>() { "Steven", "Paul", "Joe", "Kremena", "Jason", "Mark", "Gavin", "Clarke", "Charlotte", "Joe" };

            /* Instantiate a list of strings called lastNames and add 10 values to the list */
            List<string> lastNames = new List<string>() { "Partlow", "Allen", "Claufield", "Veshulava", "Young", "Fosker", "Cook", "Robus", "Jewell", "Swanson" };

            // Output all the below text to the console
            Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Lambda Expressions Assignment");
            Console.WriteLine("-----------------------------\n");

            // GOAL 1) In the Main() method, create a list of at least 10 employees. Each employee should have a first and last name, as well as an Id. At least two employees should have the first name "Joe"

            List<Employee> employess = new List<Employee>(); // Create a list consisting of instances of the Employee class called employees

            for (int i = 0; i < 10; i++) // Iterate starting i at zero until i is equal or greater than 10, incrementing i after each loop
            {
                Employee newEmployee = new Employee(); // Create a new instance of the employee object called newEmployee
                newEmployee.firstName = firstNames[i]; // Set the value of newEmployee.firstName to the value within firstNames[i]
                newEmployee.lastName = lastNames[i]; // Set the value of newEmployee.lastName to the value within lastNames[i]
                newEmployee.Id = i; // Set the value of newEmployee.Id to the value within empIDs[i]
                employess.Add(newEmployee); // Add the current instance of newEmployee to our employees list
            } // End FOR

            // GOAL 2) Using a foreach loop, create a new list of all employees with the first name "Joe"

            List<Employee> employeeJoeList = new List<Employee>(); // Create a list consisting of instances of the Employee class called employeeJoeList

            // Output all the below text to the console
            Console.WriteLine("List of employees named Joe generated with a foreach loop");
            Console.WriteLine("---------------------------------------------------------\n");

            /* Iterate through the employees list with each element being checked assigned to employee */
            foreach (Employee employee in employess)
            {

                if (employee.firstName == "Joe") // If the firstName property of the current instance of employee equals "Joe"
                {
                    employeeJoeList.Add(employee); // Add the current instance of employee to employeeJoeList
                }  // End IF

            } // End FOREACH

            /* Iterate through the newly created employeeJoeList and output it to the console */
            foreach (Employee employee in employeeJoeList) 
            { 
                Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.Id); // Concatenate this string to and output to the console
            }; // End FOREACH

            // GOAL 3) Perform the same action again, but this time with a lambda expression

            List<Employee> newEmployeeList = employess.Where(x => x.firstName == "Joe").ToList();

            // Output all the below text to the console
            Console.WriteLine("\nList of employees named Joe generated with a lambda expression");
            Console.WriteLine("----------------------------------------------------------------\n");

            /* Iterate through the newly created newEmployeeList and output it to the console */
            foreach (Employee employee in newEmployeeList)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.Id); // Concatenate this string to and output to the console
            }; // End FOREACH

            // GOAL 4) Using a lambda expression, make a list of all employees with an Id number greater than 5

            List<Employee> newEmployeeIDList = employess.Where(x => x.Id > 5).ToList();

            // Output all the below text to the console
            Console.WriteLine("\nList of employees with an employee id greater than 5 generated with a lambda expression");
            Console.WriteLine("-----------------------------------------------------------------------------------------\n");

            /* Iterate through the newly created newEmployeeIDList and output it to the console */
            foreach (Employee employee in newEmployeeIDList)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.Id); // Concatenate this string to and output to the console
            }; // End FOREACH
            Console.ReadLine(); // Pause the application

        } // End MAIN

    } // End CLASS

} // End Lambda_Express_Assign NAMESPACE
