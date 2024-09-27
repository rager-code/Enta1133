using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKramerLab3Assignment
{
    internal class DiceRoller
    {
        internal int countSide = 6;//D6 = 6 sides
        internal int Roll()//Roll is in charge of the rolling
        {
            Random random = new Random();//We take the random class and assign it to a variable to use.
            
            int randOutput = random.Next(1, countSide + 1);// adds 1 to the countside and 1 as a min number.

            Console.WriteLine(randOutput + "!!!");//Prints the number / ouput of the dice roll and adds !!! to the end of it.

            return randOutput;//Returns the randomOutput number.


        }
    }
}
