using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKramerLab3Assignment
{
    internal class Computer
    {
       
        internal bool rolledD6 = false;//Setting up the booleans for D6.
        internal bool rolledD8 = false;//Setting up the booleans for D8.
        internal bool rolledD12 = false;//Setting up the booleans for D12.
        internal bool rolledD20 = false;//Setting up the booleans for D20.
        internal int dicePicker = 0;//dicePicker score is set to 0.
        internal int cpuScore = 0;//cpuScore score is set to 0.


       
        internal int CPUDiceChooser()//Chooses the dice for the computer with random.
        {
            Random random = new Random();
            dicePicker = random.Next(1, 5);//Chooses between 4 different dice

            return dicePicker;//returns the number that are choosen
        }

        internal int CPUDice()
        {
            
            DiceRoller sixSides = new DiceRoller();//
            DiceRoller eightSides = new DiceRoller();
            DiceRoller twelveSides = new DiceRoller();
            DiceRoller twentySides = new DiceRoller();//
            
            sixSides.countSide = 6;//setting sides to D6
            eightSides.countSide = 8;//setting sides to D8
            twelveSides.countSide = 12;//setting sides to D12
            twentySides.countSide = 20;//setting sides to D20

           
            if (dicePicker == 1) //If dicepicker is 1 then roll a D6.
            {   
                if (rolledD6 == false)//checks if this dice has alreay been rolled
                {   //if it hasnt been rolled yet, it will roll this dice, otherwise it will try the  CPUDiceRoller and the CPUDiceSelector functions again until it is a different dice value picked.
                    Console.WriteLine("The CPU will roll a D6");

                    Console.WriteLine("The CPU rolled a");
                    cpuScore += sixSides.Roll();
                    
                    rolledD6 = true;
                }
                else
                {
                    CPUDiceChooser();
                    CPUDice();
                }
            }   //checks if this dice has alreay been rolled
            else if (dicePicker == 2) //If dicepicker is 1 then roll a D8.
            {       //if it hasnt been rolled yet, it will roll this dice, otherwise it will try the  CPUDiceRoller and the CPUDiceSelector functions again until it is a different dice value picked.
                if (rolledD8 == false)
                {
                    Console.WriteLine("The CPU will roll a D8");

                    Console.WriteLine("The CPU rolled a");
                    cpuScore += eightSides.Roll();
                    
                    rolledD8 = true;
                }
                else
                {
                    CPUDiceChooser();
                    CPUDice();
                }
            }   
            else if (dicePicker == 3)//If dicepicker is 1 then roll a D12.
            {      
                if (rolledD12 == false)
                {
                    Console.WriteLine("The CPU will roll a D12");

                    Console.WriteLine("The CPU rolled a");
                    cpuScore += twelveSides.Roll();
                    
                    rolledD12 = true;
                }
                else
                {
                    CPUDiceChooser();
                    CPUDice();
                }
            }   
            else if (dicePicker == 4)//If dicepicker is 1 then roll a D20.
            {       
                if (rolledD20 == false)
                {
                    Console.WriteLine("The CPU will roll a D20");

                    Console.WriteLine("The CPU rolled a");
                    cpuScore += twentySides.Roll();
                    
                    rolledD20 = true;
                }
                else
                {
                    CPUDiceChooser();
                    CPUDice();
                }
            }
            return cpuScore;//return the cpu score.
        }
    }
}
