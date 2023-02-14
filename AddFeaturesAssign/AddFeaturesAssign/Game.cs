// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 8: Additional Features Assignment
// AUTHOR: Steven Partlow
// DATE: 13/02/2023

// GOALS

// 3) Chain two constructors together - DONE

// GAME CLASS DEFINITION

using System;

namespace AddFeaturesAssign
{

    class Game // This class represents a simple game object with three properties
    {

        /* CONSTRUCTOR */

        // GOAL 3) Chain two constructors together

        /* This chains of the orignal class constructor for this class and only require the name and platfom of the game, the release year is set to the current year */

        public Game(string name, string platform) : this(name, platform, DateTime.Now.Year)
        {
        } // End CALL CHAIN CONSTRUCTOR

        /* Constructor for the Game class has three parameters, equating to each class property, who's values are then assigned to each releated class property */

        public Game(string name, string platform, int releaseYear)
        {
            Name = name; // Set class property Name to the value of the parameter name
            Platform = platform; // Set class property Platform to the value of the parameter platform
            ReleaseYear = releaseYear; // Set class property ReleaseYear to the value of the parameter releaseYear
        } // End CONSTRUCTOR

        /* PROPERTIES */

        public string Name { get; set; } // The games name which is stored as a string variable
        public string Platform { get; set; } // The games platform which is stored as a string variable
        public int ReleaseYear { get; set; } // The games release year which is stored as a integer variable

    } // End Game CLASS

} // // End AddFeaturesAssign NAMESPACE
