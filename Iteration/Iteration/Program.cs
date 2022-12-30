// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 2: Iteration Tutorial
// AUTHOR: Steven Partlow
// DATE: 29/12/2022

using System; // Use the base system library
using System.Collections.Generic; // Use the generic section of the collections library this will allow us to use both lists and arrays


class Program
{
    static void Main(string[] args)
    {
        // Output all the below text to the display
        Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
        Console.WriteLine("----------------------------------\n");
        Console.WriteLine("Iteration Tutorial");
        Console.WriteLine("------------------");

        // Iteration - Part 1 (29/12/22)

        int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 }; // Instansiate a new array consisting of nine integer values to represent test scores

        for (int i = 0; i < testScores.Length; i++) // Start a FOR loop, with the counter variable i which will count from zero to the lenghth of the testScores array
                                                    // After each iteration of the loop i will increment by one
        {
            if (testScores[i] > 85) // If the current value in testScores we are checking is greater than 85
            {
                Console.WriteLine("Passing test score: " + testScores[i]); // Print the test score to the console
            } // End IF

        } // End FOR

        string[] names = { "Jesse", "Erik", "Daniel", "Adam" }; // Instansiate a new array consisting of four string values to represent peoples names

        for (int j = 0; j < names.Length; j++) // Start a FOR loop, with the counter variable j which count from zero to the length of the testScores array
                                               // After each iteration of the loop j will increment by one
        {
            if (names[j] == "Jesse") // If the current values in names equals Jesse then 
            {
                Console.WriteLine(names[j]); // Print the name to the console
            } // End IF

     // Iteration Tutorial -Part 2(30 / 12 / 22)

            Console.WriteLine(names[j]); // This will print the current element being checked within the array

        } // End FOR

        //List<int> testScores = new List<int>(); // Create an instance of a list object consisting of integer data types called testScores
        //testScores.Add(98); // Add this value to the list testScores
        //testScores.Add(99); // Add this value to the list testScores
        //testScores.Add(81); // Add this value to the list testScores
        //testScores.Add(72); // Add this value to the list testScores
        //testScores.Add(70); // Add this value to the list testScores

        foreach (int score in testScores) // Iterate through the list testScores assigning the currently checked value to the variable score
        {
            if (score > 85) // If the current value of score is greater than 85
            {
                Console.WriteLine("Passing test score: " + score); // Concatenate this string and print to the console
            } // End IF
        } // End FOREACH

       // List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" }; // Create a new instance of a list object consisting of string data types called names and add four values to the list

        foreach (string name in names) // Iterate through the list names assigning the currently check value to the variable name
        {
            if (name == "Jesse")  // If the current value name is equal to Jesse
            {
                Console.WriteLine(name); // Print the current value of the variable name to the console
            } // End IF
        } // End FOREACH

        foreach (string name in names) // Iterate through the list of names assigning the currently checked value to the variable name
        {
            Console.WriteLine(name); // Print the current value of the variable name to the console
        } // End FOREACH

        // List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 }; // Create a new instance of a list object consisting of integer data types called testScores and add five values to the list
        List<int> passingScores = new List<int>(); // Create an empty instance of the list object which will utilise integer values

        foreach (int score in testScores) // Iterate through the list of testScores assigning the currently checked value to the variable score
        {
            if (score > 85) // If the current value of score is greater than 85
            {
                passingScores.Add(score); // Add the current value of score to the list passingscores
            } // End IF

        } // End FOREACH
  
        Console.WriteLine(passingScores.Count); // Count the number of total elements within the list passingScores and output the value to the console

        Console.ReadLine(); // Pause the application so we can view the output

    } // End MAIN

} // End CLASS
