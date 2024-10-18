using GD12_1133_A2_AdenKramer_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace GD12_1133_A2_AidenKramer_01
{
    internal class Player
    {
        internal int pDiceRoll = 0;
        internal bool rolledD6 = false;
        internal bool rolledD8 = false;
        internal bool rolledD12 = false;
        internal bool rolledD20 = false;
        internal bool rolledD25 = false;

        //initializing variable used for usernames
        internal string? username;

        internal int pScore = 30;//Used to store the score of dice rolls.

        internal string PlayerName()//function Used to get username.
        {
            

            username = Console.ReadLine();
            

            return username;//returns username to the PlayerName



        }


       



        



        internal void DiceInv()//keeps the value of the dice stored.
        {
            Console.WriteLine("______________________________________________");
            Console.WriteLine("You may now choose your Next Weapon of Choice!");//tell the player they cant roll the same dice 
            
            Console.WriteLine("");

            //checks if the dice has already been rolled
            if (rolledD6 == false)
            {   //if its false then print D#, otherwise print you already rolled this dice.
                Console.WriteLine("________________________________________________________________________________________");//net
                Console.WriteLine(@"Option 1: { * Retes  ( weighted net )
                          
   
                          ›      ");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("You already Attacked Your Opponent with a * Retes  ( weighted net )");//tell the player they cant roll the same dice
            }
            //checks if the dice has already been rolled
            if (rolledD8 == false)
            {   //if its false then print D#, otherwise print you already rolled this dice.
                Console.WriteLine("________________________________________________________________________________________");//sword1
                Console.WriteLine(@"Option 2: { ** Honshu  ( Sword )  

               

                                                            ");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("You already Attacked Your Opponent with a ** honshu ( Sword )");//tell the player they cant roll the same dice
            }
            //checks if the dice has already been rolled
            if (rolledD12 == false)
            {   //if its false then print D#, otherwise print you already rolled this dice.
                Console.WriteLine("________________________________________________________________________________________ ");//Sword2
                Console.WriteLine(@"Option 3: { *** Gladius  ( Short Sword )                                                                                           
                                                                      
                    ");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("You already Attacked Your Opponent with a *** Gladius  ( short sword )");//tell the player they cant roll the same dice
            }
            //checks if the dice has already been rolled
            if (rolledD20 == false)
            {   //if its false then print D#, otherwise print you already rolled this dice.
                Console.WriteLine("________________________________________________________________________________________");//Spear
                Console.WriteLine(@"Option 4: { **** Hasta ( Spear )         

               
                                                                                                                               ");
                Console.WriteLine("________________________________________________________________________________________");
                Console.WriteLine("");

            }
            else
            {
                Console.WriteLine("You already Attacked Your Opponent with a **** Hasta ( spear )");//tell the player they cant roll the same dice
                Console.WriteLine("");
                Console.WriteLine("______________________________________________");
            }
            if (rolledD25 == false)
            {
                
                Console.WriteLine(@"Option 5: ***** Health Potion




                                                       ");
                Console.WriteLine("________________________________________________________________________________________");
            }
            else
            {
                Console.WriteLine("You already Used Your  ***** Potion");
            }

            
        }
        internal int DiceSelect()//keeps the dice stored.
        { 
            DiceRoller sixSides = new DiceRoller();//Telling the dice roller all the types of dice
            DiceRoller eightSides = new DiceRoller();//Telling the dice roller all the types of dice
            DiceRoller twelveSides = new DiceRoller();//Telling the dice roller all the types of dice
            DiceRoller twentySides = new DiceRoller(); //Telling the dice roller all the types of dice
            DiceRoller twentyFiveSides = new DiceRoller();

            sixSides.countSide = 10;//assigning the count side for d6
            eightSides.countSide = 20;//assigning the count side for d8
            twentyFiveSides.countSide = 25;
            twelveSides.countSide = 30;//assigning the count side for d12
            twentySides.countSide = 40;//assigning the count side for d20
            

                    Console.WriteLine("       _.-\"/______________________/////");
                    Console.WriteLine("       `'-.\\~~~~~~~~~~~~~~~~~~~~~~\\\\\\\\\\");
                    string? selectedDice = Console.ReadLine(); //Lets you choose your dice with the keyboard.


            if (selectedDice == "D6" || selectedDice == "6" || selectedDice == "d6" || selectedDice == "1" || selectedDice == "option 1" || selectedDice == "Option 1")//checks for keyboard input before runing the next code
            {   
                if (rolledD6 == false)//checks to see if this dice had been rolled before.
                {
                    Console.WriteLine("          ./~");
                    Console.WriteLine("(=@@@@@@@=[}=================--");
                    Console.WriteLine("          `\\_");
                    Console.WriteLine(username + "'s Attack Dealt?");//if not true roll the dice

                    pScore = sixSides.Roll();
                    rolledD6 = true;

                }
                else
                {   
                    DiceInv();//If you try to choose the same dice keep these 2 functions open until a new dice is chosen
                    DiceSelect();//If you try to choose the same dice keep these 2 functions open until a new dice is chosen
                }
            }
            else if (selectedDice == "D8" || selectedDice == "8" || selectedDice == "d8" || selectedDice == "2" || selectedDice == "option 2" || selectedDice == "Option 2")//checks for keyboard input before runing the next code
            {
                if (rolledD8 == false)//checks to see if this dice had been rolled before.
                {
                    Console.WriteLine("          ./~");
                    Console.WriteLine("(=@@@@@@@=[}=================--");
                    Console.WriteLine("          `\\_");
                    Console.WriteLine(username + "'s Attack Dealt??");//if not true roll the dice
                    pScore = eightSides.Roll();
                    rolledD8 = true;


                }
                else
                {   
                    DiceInv();//If you try to choose the same dice keep these 2 functions open until a new dice is chosen
                    DiceSelect();//If you try to choose the same dice keep these 2 functions open until a new dice is chosen
                }
            }
            else if (selectedDice == "D12" || selectedDice == "12" || selectedDice == "d12" || selectedDice == "3" || selectedDice == "option 3" || selectedDice == "Option 3")//checks for keyboard input before runing the next code
            {
                if (rolledD12 == false)//checks to see if this dice had been rolled before.
                {
                    Console.WriteLine("          ./~");
                    Console.WriteLine("(=@@@@@@@=[}=================--");
                    Console.WriteLine("          `\\_");
                    Console.WriteLine(username + "'s Attack Dealt???");//if not true roll the dice
                    pScore = twelveSides.Roll();
                    rolledD12 = true;

                }
                else
                {   
                    DiceInv();//If you try to choose the same dice keep these 2 functions open until a new dice is chosen
                    DiceSelect();//If you try to choose the same dice keep these 2 functions open until a new dice is chosen
                }
            }
            else if (selectedDice == "D20" || selectedDice == "20" || selectedDice == "d20" || selectedDice == "4" || selectedDice == "option 4" || selectedDice == "Option 4")//checks for keyboard input before runing the next code
            {
                if (rolledD20 == false)//checks to see if this dice had been rolled before.
                {    //if false will roll the dice
                    Console.WriteLine("          ./~");
                    Console.WriteLine("(=@@@@@@@=[}=================--");
                    Console.WriteLine("          `\\_");
                    Console.WriteLine(username + "'s Attack Dealt????");//if not true roll the dice
                    pScore = twentySides.Roll();
                    rolledD20 = true;

                }
                else
                {  
                    DiceInv();//If you try to choose the same dice keep these 2 functions open until a new dice is chosen
                    DiceSelect();//If you try to choose the same dice keep these 2 functions open until a new dice is chosen
                }
            }
            else if (selectedDice == "D25" || selectedDice == "25" || selectedDice == "d25" || selectedDice == "5" || selectedDice == "option 5" || selectedDice == "Option 5")//checks for keyboard input before runing the next code
            {
                if (rolledD25 == false)//checks to see if this dice had been rolled before.
                {
                    Console.WriteLine("          ./~");
                    Console.WriteLine("(=@@@@@@@=[}=================--");
                    Console.WriteLine("          `\\_");
                    Console.WriteLine(username + "'s Attack Dealt?");//if not true roll the dice

                    pScore = twentyFiveSides.Roll();
                    rolledD25 = true;

                }
                else
                {
                    DiceInv();//If you try to choose the same dice keep these 2 functions open until a new dice is chosen
                    DiceSelect();//If you try to choose the same dice keep these 2 functions open until a new dice is chosen
                }
            }
            else
            {
                DiceInv();
                DiceSelect();
            }
            return pScore; //returns the total score of every single roll and adds them.
        }

        internal void Remove(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
