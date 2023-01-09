// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 5: Inheritance Assignment
// AUTHOR: Steven Partlow
// DATE: 09/01/2023

// PERSON CLASS DEFINITION

// GOALS
// 1) Create a class called Person and give it two properties, each of data type string. One called FirstName, the other LastName. - DONE
// 2) Give this class a void method called SayName() that takes no parameters and simply writes the person's full name to the console in the format of: "Name: [full name]". - DONE

using System;

namespace InheritanceAssign
{
    // GOAL 1) Create a class called Person and give it two properties, each of data type string. One called FirstName, the other LastName

    class Person // A class definition for a Person Object
    {
        public string FirstName { get; set; } // A string to represent a person's first name
        public string LastName { get; set; } // A string to represent a person's second name

        // GOAL 2) Give this class a void method called SayName() that takes no parameters and simply writes the person's full name to the console in the format of: "Name: [full name]"

        public void SayName() // A method to output the person's name to the console
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); // Concatenate this string with the firstName and lastName variables and output to the console
        } // SayName Method

    } // End Person CLASS Definition

} // End InheritanceAssign NAMESPACE
