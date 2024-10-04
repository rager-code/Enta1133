using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AKramerLab3Assignment
{
    internal class PlayerCPU
    {
        internal int cpuDiceScore = 0; 
        internal int pDiceRoll = 0;
        internal bool playerFirst = false;
        int turnNumbers = 4;
        Player player = new Player();
        Computer cpu = new Computer();

        internal void winChooser()
        {
            if (player.pScore > cpu.cpuScore) 
            {
                pDiceRoll++;

                Console.WriteLine("");
                Console.WriteLine("Your Wins In Battle: " + pDiceRoll);
                Console.WriteLine("");

            }
            else if (player.pScore < cpu.cpuScore)
            {
                cpuDiceScore++;


                Console.WriteLine("");
                Console.WriteLine("Your Losses In Battle: " + cpuDiceScore);
                Console.WriteLine("");
            }
            if (player.pScore == cpu.cpuScore)
            {
                
                


            }
                    



        }

        internal bool TurnChoose()//function for selecting who goes first.
        {
            player.PlayerName();//function in charge of creating and storing player's username.

            Console.WriteLine("We will now choose who goes first!!!");
            Console.WriteLine("");

            Random random = new Random();
            int turnRandom = random.Next(1, 3);//Makes the player or cpu go first depending on if a 1 or 2 gets rolled 50/50 chance.

            if (turnRandom == 1)
            {
                playerFirst = true;
            }
            else if (turnRandom == 2)
            {
                playerFirst = false;
            }

            return playerFirst;//returns playerFirst 

        }
        internal void PlayerCPURoll()//this function is in charge of the computer and player rolls
        {

            if (playerFirst == true)//If the player starts out first then the code runs in a pattern of player, computer ect...
            {

                Console.WriteLine(player.username + " Will Attack first, Choose Your Weapon Of Choice!");//Prints your username and tells you that you are up first.

                for (int i = 0; i < turnNumbers; i++)
                {
                    player.DiceInv();//Gives you 4 Dice options to select from.
                    player.DiceSelect();//Gives you D6, D8, D12 and D20.


                    cpu.CPUDiceChooser();//Gives Cpu 4 options but the computer randomly picks an option.
                    cpu.CPUDice();//Gives computer D6, D8, D12 and D20.

                    
                    winChooser();
      
                    
                    Console.WriteLine(",_._._._._._._._._|__________________________________________________________,    ");
                    Console.WriteLine("|_|_|_|_|_|_|_|_|_|________________________Round Over_______________________/   ");
                    Console.WriteLine("                  !   ");


                    Console.WriteLine("{         After adding up the score from the last round: " + player.username + " has: { " + player.pScore + " } DMG Points!! (:     }");
                    Console.WriteLine("{         After adding up the score from the last round the computer has: { " + cpu.cpuScore + " } DMG Points!! (:<      }");

                    


                }
                

                WinController();

                PlayAgain();
            }

            else//if the player fails to go first then the computer goes first.
            {
                Console.WriteLine(" The Other Warrior Will Attack first And Will Select His Weapon of Choice! (:< ");//Tells player that the computer is going first

                for (int i = 0; i < turnNumbers; i++)
                {
                    cpu.CPUDiceChooser();//runs the code for the cpus dice inventory
                    cpu.CPUDice();//runs the code for the cpus dice roller

                    player.DiceInv();//runs the code for the players dice inventory
                    player.DiceSelect();// runs the code for the players dice choice

                    winChooser();

                    Console.WriteLine(",_._._._._._._._._|__________________________________________________________,    ");
                    Console.WriteLine("|_|_|_|_|_|_|_|_|_|________________________Round Over_______________________/   ");
                    Console.WriteLine("                  !   ");

                    Console.WriteLine("{         After adding up the score from the last round: " + player.username + " has dealt: { " + player.pScore + " } Damage!! (:     }");
                    Console.WriteLine("{         After adding up the score from the last round the computer has dealt: { " + cpu.cpuScore + " } Damage!! (:<      }");


                    
                }



                WinController();

                PlayAgain();


            }
        }

        internal void WinController()//Chooses to see if the player or computer wins or loses or gets a tie.
        {
            
                Console.WriteLine("Your Wins In Battle: " + pDiceRoll);
                Console.WriteLine("Your Losses In Battle: " + cpuDiceScore);

                if (pDiceRoll > cpuDiceScore)//if the player or cpu wins the game
                {

                    Console.WriteLine("");
                    Console.WriteLine("After A Long Hard Battle, Hearing Only The Sword Clashes In The Air, " + player.username + " Wins The Fight And Becomes A Champion!! Of The Gladiator Pit With Only A Mere " + cpuDiceScore + " Losses To His Name! (: ");
                    Console.WriteLine("");

                }
                else if (pDiceRoll < cpuDiceScore)//if the player or cpu wins the game
                {

                    Console.WriteLine("You May Have Lost The Battle, But Not The War!");
                    Console.WriteLine("You Made It Out Of The Pit Alive This Time By Chance, You Might Not Be So Lucky next Time.");
                    Console.WriteLine("I Can See That You Have What It Takes To Become A Champion Of The Colosseum One Day! Come Back When You Are Stronger.. ");
                    
                }
                if (pDiceRoll == cpuDiceScore)//if the player or cpu wins the game
                {

                    Console.WriteLine("With A Brutal Fight to the Death, Both Gladiators gave it their all! But Unfortunately " + player.username + " ties with His Opponent!!  T_T ");


                }
            


        }
        internal void PlayAgain()//Play again function referenced above
        {
            GameManager manager = new GameManager();//calls from GameManager



            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("  .oooooo.                                              ");//prints Game Over
            Console.WriteLine(" d8P'  `Y8b                                            ");
            Console.WriteLine("888            .oooo.   ooo. .oo.  .oo.    .ooooo.      ");
            Console.WriteLine("888           `P  )88b  `888P\"Y88bP\"Y88b  d88' `88b     ");
            Console.WriteLine("888     ooooo  .oP\"888   888   888   888  888ooo888     ");
            Console.WriteLine("`88.    .88'  d8(  888   888   888   888  888    .o     ");
            Console.WriteLine("`Y8bood8P'   `Y888\"\"8o o888o o888o o888o `Y8bod8P'     ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("  .oooooo.");
            Console.WriteLine(" d8P'  `Y8b                                            ");
            Console.WriteLine("888      888 oooo    ooo  .ooooo.  oooo d8b     ");
            Console.WriteLine("888      888  `88.  .8'  d88' `88b `888\"\"8P ");
            Console.WriteLine("888      888   `88..8'   888ooo888  888    ");
            Console.WriteLine("`88b    d88'    `888'    888    .o  888   ");
            Console.WriteLine(" `Y8bood8P'      `8'     `Y8bod8P' d888b  ");//Blank to create an extra line in the game
            Console.WriteLine("");
            


            Console.WriteLine("Do you dare to rematch another time? ");//asks player if they want to rematch
            Console.WriteLine("");
            Console.WriteLine("OfC, Mabey or another day? ");

            string playerPlayAgainInput = Console.ReadLine();//player input readline

            

            if (playerPlayAgainInput == "yes" || playerPlayAgainInput == "Yes" || playerPlayAgainInput == "ofc" || playerPlayAgainInput == "OFC")//player input to play again
            {
                player.rolledD6 = false;
                player.rolledD8 = false;
                player.rolledD12 = false;
                player.rolledD20 = false;

                cpu.rolledD6 = false;
                cpu.rolledD8 = false;
                cpu.rolledD12 = false;
                cpu.rolledD20 = false;

                manager.PlayGame();

            }
            else
            {
                manager.playerRePlayGame = false;
                Console.WriteLine("Done already are you?");//text when you choose to leave
                Environment.Exit(0 );//Exits the program
            }

        }
    }
}
