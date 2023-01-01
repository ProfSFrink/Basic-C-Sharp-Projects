// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 2: Console App Assignment
// AUTHOR: Steven Partlow
// DATE: 31/12/2022

// GOALS

// PART 1
// ------
// 1-1) A one-dimensional array of strings. - DONE
// 1-2) Ask the user to input some text. - DONE
// 1-3) A loop that iterates through each string in the array and adds the user's text input to the end of each string. - DONE
// 1-4) Then create a loop that prints off each string in the array on a separate line. - DONE
// 1-5) Save and execute your code. - DONE

// PART 2
// ------
// 2-1) An infinite loop. - DONE
// 2-2) Save your code. - DONE
// 2-3) Fix the infinite loop so that it will execute properly. - DONE
// 2-4) Save and execute your code. - DONE

// PART 3
// ------
// 3-1) A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator. - DONE
// 3-2) Save and execute your code. - DONE
// 3-3) A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator. - DONE
// 3-4) Save and execute your code. - DONE

// PART 4
// ------
// 4-1) A list of strings where each item in the list is unique. - DONE
// 4-2) Ask the user to input text to search for in the list. - DONE
// 4-3) A loop that iterates through the list and then displays the index of the list that contains matching text on the screen. - DONE
// 4-4) Add code to the loop that tells a user if they put in text that isn’t in the list. - DONE
// 4-5) Add code to the loop that stops it from executing once a match has been found. - DONE
// 4-6) Save and execute your code. - DONE

// PART 5
// ------
// 5-1) A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list. - DONE
// 5-2) Create a loop that iterates through the list and then displays the indices of the list that contain matching text on the screen. - DONE
// 5-3) Add code to the loop that tells a user if they put in text that isn’t in the list. - DONE
// 5-4) Save and execute your code. - DONE

// PART 6
// ------
// 6-1) Create a list of strings that has at least two identical strings in the list. - DONE
// 6-2) Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list. - DONE
// 6-3) Save and execute your code. - DONE

using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Output all the below text to the display
        Console.WriteLine("PITMAN TRAINING / THE TECH ACADEMY");
        Console.WriteLine("----------------------------------\n");

        /* ---------------------------------------------------------------- PART 1 ----------------------------------------------------------------------------------- */

        Console.WriteLine("Console App Assignment - Part 1"); // Output this text to the console then start a new line
        Console.WriteLine("-------------------------------\n");

        // GOAL 1-1) A one-dimensional array of strings
        string[] games = { "Moon Patrol", "10-Yard Fight", "Battle Chopper", "Lightning Swords", "R-Type", "In the Hunt" }; // Instanstiate an array of string called games and add these six values to the array

        // GOAL 1-2) Ask the user to input some text
        Console.Write("Please enter some text into the application, thank you: "); // Output this text to the console
        string userInput = Console.ReadLine(); // Store the text the user enters into the string variable userInput

        // GOAL 1-3) A loop that iterates through each string in the array and adds the user's text input to the end of each string

        Console.WriteLine(); // Adds a blank line to the console window
        for (int i = 0; i < 6; i++) // Start a FOR loop using counter variable i start at zero and keep iterating until i is six or greater
        {
            games[i] = games[i] + " " + userInput; // Concatenate the current value of the games array with the userinput and store this new string in the current index of the games array

            // GOAL 1-4) Then create a loop that prints off each string in the array on a separate line (DOING THIS AS PART OF THE SAME LOOP AS MORE EFFICENT THAN USING TWO SEPERATE FOR LOOPS)

            Console.WriteLine(games[i]); // Output the current value of games to the console
        } // End FOR

        /* ---------------------------------------------------------------- PART 2 ----------------------------------------------------------------------------------- */

        Console.WriteLine("\nConsole App Assignment - Part 2"); // Output this text to the console then start a new line
        Console.WriteLine("-------------------------------\n");

        //// GOAL 2 - 1) An infinite loop
        //bool infinite = true; // Initilise a boolean variable and set it to true

        //while (infinite) // This is an infinite while loop that will not stop looping as infinite will always be set to true
        //{
        //    Console.WriteLine("This is an infinite loop that will never end!. You will have force the application to quit!."); // Output this text to the console
        //} // End While

        // GOAL 2-3) Fix the infinite loop so that it will execute properly
        bool infinite = true; // Initilise a boolean variable and set it to true

        while (infinite) // This loop will now execute once as it will change infinite to false after one loop, exiting the while loop
        {
            infinite = false; // Set the boolean variable infinite to false to exit the while loop
            Console.WriteLine("The while loop will now exit correctly!\n"); // Output this text to the console
        } // End While

        /* ---------------------------------------------------------------- PART 3 ----------------------------------------------------------------------------------- */

        Console.WriteLine("Console App Assignment - Part 3"); // Output this text to the console then start a new line
        Console.WriteLine("-------------------------------\n");

        // GOAL 3-1) A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator
        for (int c = 1; c < 11; c++) // This FOR loop will count from 1 to 10 using the integer c as a counter
        {
            Console.WriteLine("The loop has run " + c + " times."); // Concatenate c into this string and out it to the console.
        } // End FOR

        // GOAL 3-3) A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator

        int totalValue = 0; // Initalise an integer called totalValue with a value of zero
        do
        {
            Console.Write("\nPlease enter a numerical value, this will be added to the current total: "); // Output this text to the console
            totalValue = totalValue + Convert.ToInt32(Console.ReadLine()); // Take the value the user inputs and add it the current value of totalValue
            Console.WriteLine("\nThe current total is: " + totalValue); // Concatenate the current value of totalValue to this string
        } // End DO WHILE
        while (totalValue <= 12500); // After the loop has run once we check if totalValue is less or equal to 12500 if it is we iterate through the loop again

        Console.WriteLine("\nThe total has exceeded 12500 and the application will now exit. Thank You!.\n"); // Output this text to the console

        /* ---------------------------------------------------------------- PART 4 ----------------------------------------------------------------------------------- */

        Console.WriteLine("Console App Assignment - Part 4"); // Output this text to the console then start a new line
        Console.WriteLine("-------------------------------\n");

        // GOAL 4-1) A list of strings where each item in the list is unique

        List<string> c64Games = new List<string>() { "Summer Games", "Jumpman", "Movie Monster Game", "Subterranea", "Alleykat", "Winter Games", "Lee", "Marauder", "Battle Valley", "Street Sports Baseball", "Impossible Mission", "Gateway to Apshai", "Stormlord", "Idridis Alpha" }; // Instanstiate a new instance of the list object called c64Games and assign these fourteen values

        // GOAL 4-2) Ask the user to input text to search for in the list

        Console.WriteLine("Commodore 64 Game Database"); // Output this text to the console
        Console.WriteLine("--------------------------"); // Output this text to the console

        Console.Write("\nPlease enter a game name to search for: "); // Output this text to the console
        string searchString = Console.ReadLine(); // Take the user input and assign it to the string searchString
        Console.WriteLine(); // Add a blank line to the console

        // 4-3) A loop that iterates through the list and then displays the index of the list that contains matching text on the screen

        bool matchFound = false; // A boolean variable to track if we have found a match within our database which we initally set to false

        for (int g = 0; g <= 13; g++) // Start a FOR loop using integer variable g as a counter starting at zero and going up to thirteen
        {

            if (c64Games[g].ToUpper().Contains(searchString.ToUpper())) // We check if the current value of c64Games contains the value in searchString, we also convert both values to uppercase to aid with case accuracy, then if we find a match
            {
                // The current value of the counter g will represet our index position in our list
                Console.WriteLine("Game found at index position " + g); // We concatenate that value to this string then output it to the console
                matchFound = true; // We can set this to true as we have a match

                // GOAL 4-5) Add code to the loop that stops it from executing once a match has been found
                break; // We break the loop here as we have found a match and there is no need to continue
            } // End IF

        } // End FOR

        // GOAL 4-4) Add code to the loop that tells a user if they put in text that isn’t in the list

        if (!matchFound) // If after the above FOR loop has completed and matchFound is still false then we had no match and we inform the user
        {
            Console.WriteLine("No match found in the database, sorry!."); // Output this text to the console
        } // End IF

        /* ---------------------------------------------------------------- PART 5 ----------------------------------------------------------------------------------- */

        Console.WriteLine("\nConsole App Assignment - Part 5"); // Output this text to the console then start a new line
        Console.WriteLine("-------------------------------\n");

        // GOAL 5-1) A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list

        List<string> dataEastGames = new List<string>() { "Burger Time", "Bad Dudes VS Dragonninja", "Gate of Doom", "Wizard Fire", "Breakthru", "Tumblepop", "Darwin 4878", "Sly Spy", "Chain Reaction", "Gate of Doom", "Lock N Chase" }; // Instanstiate a new list of strings called dataEastGames and assign it these eleven values

        Console.WriteLine("Data East Games Database"); // Output this text to the console
        Console.WriteLine("------------------------"); // Output this text to the console

        Console.Write("\nPlease enter a game name to search for: "); // Output this text to the console
        searchString = Console.ReadLine(); // Take the user input and assign it to the string searchString
        Console.WriteLine(); // Add a blank line to the console

        // GOAL 5-2 ) Create a loop that iterates through the list and then displays the indices of the list that contain matching text on the screen

        matchFound = false; // A boolean variable to track if we have found a match within our database which we initally set to false

        for (int g = 0; g <= 10; g++) // Start a FOR loop using integer variable g as a counter starting at zero and going up to ten
        {

            if (dataEastGames[g].ToUpper().Contains(searchString.ToUpper())) // We check if the current value of dataEastGames contains the value in searchString, we also convert both values to uppercase to aid with case accuracy, then if we find a match
            {
                // The current value of the counter g will represet our index position in our list
                Console.WriteLine("Game found at index position " + g); // We concatenate that value to this string then output it to the console
                matchFound = true; // We can set this to true as we have a match
            } // End IF

        } // End FOR

        // GOAL 5-3) Add code to the loop that tells a user if they put in text that isn’t in the list

        if (!matchFound) // If after the above FOR loop has completed and matchFound is still false then we had no match and we inform the user
        {
            Console.WriteLine("No match found in the database, sorry!."); // Output this text to the console
        } // End IF

        /* ---------------------------------------------------------------- PART 6 ----------------------------------------------------------------------------------- */

        Console.WriteLine("\nConsole App Assignment - Part 6"); // Output this text to the console then start a new line
        Console.WriteLine("-------------------------------\n");

        // GOAL 6-1) Create a list of strings that has at least two identical strings in the list

        List<string> toaplanGames = new List<string>() { "Tiger Heli", "Truxton", "Guardian", "Alcon", "Flying Shark", "Truxton", "Zero Wing", "Snow Bros","Teki Paki" }; // Instanstiate a new list of strings called topalanGames and assign it these nine values

        List<string> alreadyExists = new List<string>(); // Instanstiate a second list of string which is empty to begin with

        Console.WriteLine("Toaplan Games Database"); // Output this text to the console
        Console.WriteLine("------------------------"); // Output this text to the console

        // GOAL 6 - 2) Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list

        foreach (string game in toaplanGames) // Iterate through the topalanGames list assigning the current value to game
        {
            if (alreadyExists.Contains(game)) // If the current value of game already appears within the alreadyExists list
            {
                Console.WriteLine(game + " has ALREADY appeared within the database!."); // We concatenate the current value of game with the already appeared message
            } // End IF
            else // If the games has NOT already appeared in our search
            {
                alreadyExists.Add(game); // Add the game to the already appeared list
                Console.WriteLine(game + " has NOT appeared within the database!."); // We concatenate the current value of game with has not appeared message
            } // End ELSE
        } // End FOREACH

        Console.ReadLine(); // Pause the application

    } // End MAIN

} // End CLASS

