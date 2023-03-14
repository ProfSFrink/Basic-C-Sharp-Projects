// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 11: Creating MVC Applications
// AUTHOR: Steven Partlow
// DATE: 25/02/2023

// USER MODEL DEFINITION

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorial.Models
{

    public class User
    {

        public int Id { get; set; } // A integer data type property called Id
        public string FirstName { get; set; } // A string data type property called FirstName 
        public string LastName { get; set; } // A string data type property called LastName
        public int Age { get; set; } // A integer data type property called Age

    } // End User CLASS

} // End MVCTutorial.Models NAMESPACE
