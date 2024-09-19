using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2AidenKramer
{
    internal class DieRoller
    {
        internal int numberOfSides = 6;
        internal int totalScore = 0;

        // Initializing Variables.
        internal void Description()
        {
            //Number of dice sides = 6 and we are setting the current total score to 0 at the start once the code is ran.

            Console.WriteLine("Rolls a six sided dice.");
            Console.WriteLine("Min Roll");
            Console.WriteLine(1);
            Console.WriteLine("Max Roll");
            Console.WriteLine(numberOfSides);

            //Prints a description of the game with the WriteLines with quotes ( tells you the min and max rolls ). Calls for numberOfSides from above.   

        }
        internal int Roll()
        {
            int outPutRandom;

            // initializing variable.
            
            Random rollInstance;

            // Assigning Random class to variable.

            rollInstance = new Random();

            // Assigning new instance of random to variable.

            outPutRandom = rollInstance.Next(1, numberOfSides + 1);

            // This is what is randomizing the dice rolls.

            Console.WriteLine("Your Roll Is " + outPutRandom);

            // This is printing the output of your roll. 

            return outPutRandom;

            // Returning the value of outPutRandom to roll function.

            
        }   
        internal void RollTotal()
        {
            totalScore += Roll();
            totalScore += Roll();
            totalScore += Roll();
            totalScore += Roll();

            // This is for adding up the 4 rolls to total.

            Console.WriteLine("Your Total Score Is " + totalScore);
            // Prints "Your Total Score Is" + the number / totalScore. 
        }
    }


}

