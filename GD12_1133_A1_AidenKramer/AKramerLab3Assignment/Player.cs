using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKramerLab3Assignment
{
    internal class Player
    {
        internal int pDiceRoll = 0;
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
            Console.WriteLine("______________________________________________");
            Console.WriteLine("You may now choose your Next Weapon of Choice!");//tell the player they cant roll the same dice 
            
            Console.WriteLine("");

            //checks if the dice has already been rolled
            if (rolledD6 == false)
            {   //if its false then print D#, otherwise print you already rolled this dice.
                Console.WriteLine("________________________________________________________________________________________");//net
                Console.WriteLine(@"Option 1: { * Retes  ( weighted net )
                          
     ›››{ÏÏÏííízzíÏzÏÏü————›  
    ———›{zzz{íí{íízízz› —›››  
     ›› —zzí{{›íí{zzíz›  ››   
        —zÏ{í{Ï{{z{í{z{       
        íÏí—zízz{íí{íÏí       
        —ÏÏz—{—{—{zííz{       
 ——{››  {ííz{{z{í{í—zíÏ   ››  
  ——›› ›ÏÏÏÏzííízíí{ííz— — ›— 
    ››{ÏüÏ6Ïízz{—zízÏzÏü{›{—› 
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

                                                                                           .<<~            
           ...:-~==++++++========~~~~~-~----~~----:---------~~~==+>([(]()^+==~~~~---~:::~+]{##).   
  ...::-~==++++++*^>>>>>>^^^^^^>^^^^^^^^^^^>>>^**^^^^^^^^+**+*+***<(]]]]]{##}}{{{{{##}}{####%#{~   
  .:-~+^<((())<>^^*^^^^^^^^^^^^^>>^^>>^>><<<>>>>^^^^^^^>>^^+=+==+=*)]}}[}#%#}{{{#{{#%{{#%%%###{=   
          ..:-=*>)(((((((((((())<<>>>^^^^*****^********^^^^^><<))((*)]{{[<*++=~~~~-~=--:~+[@@%).   
                                                                     .}[=                  ...                                      
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
                                                                      
                                                 ÆÆ   
                                               ÆÆÆÄ    
                                            ÆÆÆÆÆ      
                                          ÆÆëÆÆÆ       
                                        ÀÆ5‘ÆÆÆ        
                                      1Æë1ÆÆÆ          
                                    ‚Æ% ÆÆÆ            
                                   ÆÞ ÆÆÆ              
                                 ÆÆ ÆÆÆ                
                               ÆÆ çÆÆ                  
                             ÞÆ!ÉÆÆ                    
                            Æ0 ÆÆ                      
                          Æò ÆÆÍ                       
                        ÆÆºÆÆŽ                         
                      ÆW ÆÆÄ                           
                    ÆN ÆÆÆ                             
                  «¸ OÆÆ                               
                óÀÂZÆÆC                                
           ÆÆ  ðÆ† Æà                                  
             ÆÆÆÆÆß                                    
           yÆÆÆÎÆ                                      
          ÆÆÆÆ  ‰ÆH                                    
        ÆÆÆÆ      ÆÆ                                   
      ÆÆÆÆ                                             
   ÆÆÆÆÆ                                               
   ÆÆÆÆ                                                
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
                                                                                                      ↑↑↑↑↓                           
 ↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↗↑↑↑↑↑↑↑↑↑↑↑↑↑                 
→↑↙↖↗↓↓↘↖← ↙← ↖↑                                                       ↙↙↖↓←↙↘↘↓↗↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑       ↖ ↘↑↑↑↑↑↑↑↑↓←           
                                                                                                  ↑↑↓↑↑↑↘↗                    
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

           
        }
        internal int DiceSelect()//keeps the dice stored.
        { 
            DiceRoller sixSides = new DiceRoller();//Telling the dice roller all the types of dice
            DiceRoller eightSides = new DiceRoller();//Telling the dice roller all the types of dice
            DiceRoller twelveSides = new DiceRoller();//Telling the dice roller all the types of dice
            DiceRoller twentySides = new DiceRoller(); //Telling the dice roller all the types of dice

            sixSides.countSide = 10;//assigning the count side for d6
            eightSides.countSide = 20;//assigning the count side for d8
            twelveSides.countSide = 30;//assigning the count side for d12
            twentySides.countSide = 40;//assigning the count side for d20

                    Console.WriteLine("       _.-\"/______________________/////");
                    Console.WriteLine("       `'-.\\~~~~~~~~~~~~~~~~~~~~~~\\\\\\\\\\");
                    string selectedDice = Console.ReadLine(); //Lets you choose your dice with the keyboard.


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
            else
            {
                DiceInv();
                DiceSelect();
            }
            return pScore; //returns the total score of every single roll and adds them.
        }
    }
}
