using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKramerLab3Assignment
{
    internal class GameManager
    {
        internal void PlayGame()//Calls PlayGame
        {   
            Console.WriteLine("Aiden Kramer,  2024-09-25");//Prints my name and date
            Console.WriteLine("Welcome to Die vs Die!");//Prints game name
            
            Console.WriteLine("Please enter a username");//tells player to choose username

            PlayerCPU playerVsCPU = new PlayerCPU(); // Calls the player and the computer.
           
            playerVsCPU.TurnChoose();//Chooses who goes first from the player and computer.

            
            playerVsCPU.PlayerCPURoll();//The player an computers rolling


            Console.WriteLine("                {Game Over}");//prints Game Over
            Console.WriteLine("");//Blank to create an extra line in the game
            Console.WriteLine("     | GoodBye Have A Great Day! |");//Goodbye message
        }
    }
}
