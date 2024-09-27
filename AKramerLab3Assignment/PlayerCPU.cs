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
        internal bool playerFirst = false;

        Player player = new Player();
        Computer cpu = new Computer();

        internal bool TurnChoose()//function for selecting who goes first.
        {
            player.PlayerName();//function in charge of creating and storing player's username.

            Console.WriteLine("We will now choose who goes first!!!");
   
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
                
                Console.WriteLine(player.username + " will roll first, Please select a dice.");//Prints your username and tells you that you are up first.
                
                player.DiceInv();//Gives you 4 Dice options to select from.
                player.DiceSelect();//Gives you D6, D8, D12 and D20.

                cpu.CPUDiceChooser();//Gives Cpu 4 options but the computer randomly picks an option.
                cpu.CPUDice();//Gives computer D6, D8, D12 and D20.

                player.DiceInv();
                player.DiceSelect();

                cpu.CPUDiceChooser();
                cpu.CPUDice();

                player.DiceInv();
                player.DiceSelect();

                cpu.CPUDiceChooser();
                cpu.CPUDice();

                player.DiceInv();
                player.DiceSelect();

                cpu.CPUDiceChooser();
                cpu.CPUDice();

                WinController();
            }
            
            else//if the player fails to go first then the computer goes first.
            {   
                Console.WriteLine("The computer will now get to go first! (:< ");//Tells player that the computer is going first
               

                cpu.CPUDiceChooser();//runs the code for the cpus dice inventory
                cpu.CPUDice();//runs the code for the cpus dice roller


                player.DiceInv();//runs the code for the players dice inventory
                player.DiceSelect();// runs the code for the players dice choice

                cpu.CPUDiceChooser();
                cpu.CPUDice();


                player.DiceInv();
                player.DiceSelect();

                cpu.CPUDiceChooser();
                cpu.CPUDice();


                player.DiceInv();
                player.DiceSelect();

                cpu.CPUDiceChooser();
                cpu.CPUDice();


                player.DiceInv();
                player.DiceSelect();


                WinController();
            }
        }
        
        internal void WinController()//Chooses to see if the player or computer wins or loses or gets a tie.
        {  
            if (player.pScore > cpu.cpuScore)//checks to see if the player has a greater score then the computer.
            {
                Console.WriteLine("{         After adding up the score, " + player.username + " wins with a total of " + player.pScore + " Points!! (:     }");
            }
           
            else if (player.pScore == cpu.cpuScore)//checks to see if the computer and player have an equal score, if so they tie.
            {
                Console.WriteLine("{          After adding up the score, " + player.username + " ties with the computer!!  T_T     }");
            }
            
            else if (player.pScore < cpu.cpuScore)//checks to see if the computer has a greater score then the player.
            {
                Console.WriteLine("{        After adding up the score, the computer wins with a total of " + cpu.cpuScore + " Points!! (:<      }");
            }
        }
    }
}
