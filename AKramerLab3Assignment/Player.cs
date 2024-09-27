using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKramerLab3Assignment
{
    internal class Player
    {
        //initializing true or false statements for cheking if a dicetype has been rolled
        internal bool rolledD6 = false;
        internal bool rolledD8 = false;
        internal bool rolledD12 = false;
        internal bool rolledD20 = false;
        //initializing variable used for usernames
        internal string username;

        internal int pScore;//Used to store the score of dice rolls.

        internal string PlayerName()//function Used to get username.
        {   
            username = Console.ReadLine();

            return username;//returns username to the PlayerName
        }
        internal void DiceInv()//keeps the value of the dice stored.
        {

            Console.WriteLine("You may now choose your dice!");//tell the player they cant roll the same dice 
            
            //checks if the dice has already been rolled
            if (rolledD6 == false)
            {   //if its false then print D#, otherwise print you already rolled this dice.
                Console.WriteLine("D6");
            }
            else
            {
                Console.WriteLine("You already rolled a D6!");//tell the player they cant roll the same dice
            }
            //checks if the dice has already been rolled
            if (rolledD8 == false)
            {   //if its false then print D#, otherwise print you already rolled this dice.
                Console.WriteLine("D8");
            }
            else
            {
                Console.WriteLine("You already rolled a D8!");//tell the player they cant roll the same dice
            }
            //checks if the dice has already been rolled
            if (rolledD12 == false)
            {   //if its false then print D#, otherwise print you already rolled this dice.
                Console.WriteLine("D12");
            }
            else
            {
                Console.WriteLine("You already rolled a D12!");//tell the player they cant roll the same dice
            }
            //checks if the dice has already been rolled
            if (rolledD20 == false)
            {   //if its false then print D#, otherwise print you already rolled this dice.
                Console.WriteLine("D20");
            }
            else
            {
                Console.WriteLine("You already rolled a D20!");//tell the player they cant roll the same dice
            }

           
        }
        internal int DiceSelect()//keeps the dice stored.
        { 
            DiceRoller sixSides = new DiceRoller();//Telling the dice roller all the types of dice
            DiceRoller eightSides = new DiceRoller();//Telling the dice roller all the types of dice
            DiceRoller twelveSides = new DiceRoller();//Telling the dice roller all the types of dice
            DiceRoller twentySides = new DiceRoller(); //Telling the dice roller all the types of dice

            sixSides.countSide = 6;//assigning the count side for d6
            eightSides.countSide = 8;//assigning the count side for d8
            twelveSides.countSide = 12;//assigning the count side for d12
            twentySides.countSide = 20;//assigning the count side for d20
            
            string selectedDice = Console.ReadLine(); //Lets you choose your dice with the keyboard.

            if (selectedDice == "D6" || selectedDice == "6" || selectedDice == "d6")//checks for keyboard input before runing the next code
            {   
                if (rolledD6 == false)//checks to see if this dice had been rolled before.
                {   
                    Console.WriteLine(username + " rolled a?");//if not true roll the dice
                    pScore += sixSides.Roll();
                    rolledD6 = true;
                }
                else
                {   
                    DiceInv();//If you try to choose the same dice keep these 2 functions open until a new dice is chosen
                    DiceSelect();//If you try to choose the same dice keep these 2 functions open until a new dice is chosen
                }
            }
            else if (selectedDice == "D8" || selectedDice == "8" || selectedDice == "d8")//checks for keyboard input before runing the next code
            {
                if (rolledD8 == false)//checks to see if this dice had been rolled before.
                {  
                    Console.WriteLine(username + " rolled a!?");//if not true roll the dice
                    pScore += eightSides.Roll();
                    rolledD8 = true;


                }
                else
                {   
                    DiceInv();//If you try to choose the same dice keep these 2 functions open until a new dice is chosen
                    DiceSelect();//If you try to choose the same dice keep these 2 functions open until a new dice is chosen
                }
            }
            else if (selectedDice == "D12" || selectedDice == "12" || selectedDice == "d12")//checks for keyboard input before runing the next code
            {
                if (rolledD12 == false)//checks to see if this dice had been rolled before.
                {    
                    Console.WriteLine(username + " rolled a!!?");//if not true roll the dice
                    pScore += twelveSides.Roll();
                    rolledD12 = true;

                }
                else
                {   
                    DiceInv();//If you try to choose the same dice keep these 2 functions open until a new dice is chosen
                    DiceSelect();//If you try to choose the same dice keep these 2 functions open until a new dice is chosen
                }
            }
            else if (selectedDice == "D20" || selectedDice == "20" || selectedDice == "d20")//checks for keyboard input before runing the next code
            {
                if (rolledD20 == false)//checks to see if this dice had been rolled before.
                {    //if false will roll the dice
                    Console.WriteLine(username + " rolled a!!!?");//if not true roll the dice
                    pScore += twentySides.Roll();
                    rolledD20 = true;

                }
                else
                {  
                    DiceInv();//If you try to choose the same dice keep these 2 functions open until a new dice is chosen
                    DiceSelect();//If you try to choose the same dice keep these 2 functions open until a new dice is chosen
                }

            }//returns the total score of every single roll and adds them.
            return pScore;
        }
    }
}
