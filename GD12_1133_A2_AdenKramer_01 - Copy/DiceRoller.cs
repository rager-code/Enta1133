using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD12_1133_A2_AidenKramer_01
{
    public class DiceRoller
    {
        internal int countSide = 6;//D6 = 6 sides
        internal int Roll()//Roll is in charge of the rolling
        {
            Random random = new Random();//We take the random class and assign it to a variable to use.
            
            int randOutput = random.Next(1, countSide + 1);// adds 1 to the countside and 1 as a min number.

            Console.WriteLine("                _");
            Console.WriteLine("               /\\)");
            Console.WriteLine("              /\\/");
            Console.WriteLine("             /\\/");
            Console.WriteLine("           _/L/");
            Console.WriteLine("         (/\\_)");
            Console.WriteLine("          /%/");
            Console.WriteLine("         /%/    | " + randOutput + " Damage!" + " |");//Prints the number / ouput of the dice roll and adds !!! to the end of it.
            Console.WriteLine("        /%/");
            Console.WriteLine("       /%/");
            Console.WriteLine("      /%/");
            Console.WriteLine("     /%/");
            Console.WriteLine("    /%/");
            Console.WriteLine("   /%/");
            Console.WriteLine("  /%/");
            Console.WriteLine(" /%/");
            Console.WriteLine("/,'");
            Console.WriteLine("'");

            return randOutput;//Returns the randomOutput number.


        }
    }
}
