// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 9: Boolean Logic Tutorial
// AUTHOR: Steven Partlow
// DATE: 05/12/2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            // AND(&&) OPERATOR - Both statements MUST be TRUE
            Console.WriteLine(true && false); // FALSE
            Console.WriteLine(true && true); // TRUE
            Console.WriteLine(false && false); // FALSE

            // OR(||) OPERATOR - At least ONE statement must be TRUE
            Console.WriteLine(true || true); // TRUE
            Console.WriteLine(true || false); // TRUE
            Console.WriteLine(false || false); // FALSE

            // EQUALS(==) OPERATOR - Does each statement either side of the operator MATCH, if so result is TRUE
            Console.WriteLine(true == true);  // TRUE
            Console.WriteLine(true == false); // FALSE
            Console.WriteLine(false == false); // TRUE

            // NOT EQUALS(!=) OPERATOR - The opposite of the above EQUALS operator 
            Console.WriteLine(true != true); // FALSE
            Console.WriteLine(true != false); // TRUE
            Console.WriteLine(false != false); // FALSE

            // XOR(^) OPERATOR - If either statement is TRUE the output is TRUE however if BOTH are TRUE or FALSE the output is FALSE 
            Console.WriteLine(true ^ true); // FALSE
            Console.WriteLine(true ^ false); // TRUE
            Console.WriteLine(false ^ false); // FALSE

            // Use of multiple operators in a single statement
            Console.WriteLine(true && true && true && false); // FALSE - As the last statement is FALSE
            Console.WriteLine(true && true && true || false); // TRUE - As the last statement can be TRUE or FALSE

            Console.ReadLine();
        } // End MAIN

    } // End CLASS

} // End NAMESPACEC
