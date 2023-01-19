// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 7: Creating a Game of Blackjack and Intermediate C# Programming
// AUTHOR: Steven Partlow
// DATE: 19/01/2023

// TWENTY ONE RULES DEFINITION

// This class represents the business logic of our program, a business logic class is a that exists without the knowledge of other classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{

    class TwentyOneRules
    {
        /* TwentyOneRules PROPERTIES */

        /* A private dictionary used to represent the face values of playing cards, the key / value pair is the Face of a card and it's value as an integer */
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            /* Each K / V pair in the dictionary is the name of the face of the card and it's corresponding numerical value */

            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1 // We are making aces value one here and will account for it potentially being an eleven elsewhere within the program
        }; // End _cardValues Dictionary Definition

        /* TwentyOneRules METHODS */

        /* A method were we pass in a Hand of cards and then calculate all the possible values that hand could have and return it as an integer array */
        public static int[] GetAllPossibleHandValues(List<Card> Hand) 
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace); // Use a lambda expression to count the number of cards in the passed in Hand that have a face value equal to ace
            int[] result = new int[aceCount + 1]; // Create an array callled result the size of which will be the value of aceCount plus one
            int value = Hand.Sum(x => _cardValues[x.Face]); // Use a lambda expression to get the sum value of all cards in the hand
            result[0] = value; // Take the variable value and assign it to the first element of the array result
            if (result.Length == 1) return result; // If we only have one possible value of our hand then we can return the result array and quit the method at this point

        } // End GetAllPossibleHandValues

        public static bool CheckForBlackJack(List<Card> Hand)
        {

        } // End CheckForBlackJack Method

    } // End TwentyOneRules Definition

} // End TwentyOne NAMESPACE
