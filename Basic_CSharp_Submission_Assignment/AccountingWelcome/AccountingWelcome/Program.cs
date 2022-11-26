// Advanced Software and Web Developer Diploma
// Part IX: C# and .NET Framework - Part 1
// by Pitman Training / The Tech Academy

// MODULE 4: Basic C# Submission Assignment - Accounting Welcome Screen
// AUTHOR: Steven Partlow
// DATE: 26/11/2022

using System;

namespace AccountingWelcome
{
	class Program
	{
		static void Main() // The method Main is the first thing that is executed when the console applicatio is run
						   // Void mean we are not refering to an object and void means the method will not return a value
		{
			Console.WriteLine("Welcome to Acme Accounting Systems"); // Print this text to the console window
			Console.WriteLine("Remember, we're \"accounting\" on you!"); // Print this text to the console and use the escape character backslash (\) to display 'accounting' in double-quotes
			Console.ReadLine(); // This keeps the console window displayed until the user presses the RETURN key
		} // End MAIN

	} // End CLASS
} // End NAMESPACE
