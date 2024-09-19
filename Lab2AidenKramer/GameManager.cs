using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2AidenKramer
{
    internal class GameManager
    {

        
       


        public void PlayGame()
        {

            Console.WriteLine("Welcome to Die vs Die");

            

            

            DieRoller dierollerInstance = new DieRoller();

            // Assigns a new Instance of DieRoller to a variable. 

            dierollerInstance.Description();

            // Calling function for description.

            dierollerInstance.RollTotal();

            // Calling function for RollTotal.

            {
                /*Arithmetics
                 * The Operator ++ Increments by one ( adds by one ).
                 * The Operator -- Decrements by one ( subtracts by one ). 
                 * The Operator *  is used to Multiply ( Multiplies numbers ). 
                 * The Operator /  is used to Divide.
                 * The Operator +  is used to get Sum numbers ( 5 + 3 = 8 )
                 * The Operator -  is used to Subtract or to indicate a negitive number ( 10 - 3 = 7.   -5  ).
                 * The Operator %  is used to get the Remainder ( 10 % 3 results in 1 because 10 divided by 3 is 3 with a remainder of 1). 
                */
            }
        }


        
    }
}