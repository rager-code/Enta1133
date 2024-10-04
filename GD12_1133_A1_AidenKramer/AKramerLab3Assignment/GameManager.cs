using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AKramerLab3Assignment
{
    internal class GameManager
    {
        internal bool playerRePlayGame = true;//Set the replaygame to true


        internal void PlayGame()//Calls PlayGame
        {
            Console.WriteLine("Aiden Kramer,  2024-09-25");//Prints my name and date
            Console.WriteLine(" _____ _                  ____      _                                    ");
            Console.WriteLine("|_   _| |__   ___        / ___|___ | | ___  ___ ___  ___ _   _ _ __ ___ ");
            Console.WriteLine("  | | | '_ \\ / _ \\      | |   / _ \\| |/ _ \\/ __/ __|/ _ \\ | | | '_ ` _ \\ ");
            Console.WriteLine("  | | | | | |  __/      | |__| (_) | | (_) \\__ \\__ \\  __/ |_| | | | | | |");
            Console.WriteLine("  |_| |_| |_|\\___|       \\____\\___/|_|\\___/|___/___/\\___|\\__,_|_| |_| |_|");
            Console.WriteLine("  ___   __       ____ _                           _                 _    ");
            Console.WriteLine(" / _ \\ / _|     / ___| |__   __ _ _ __ ___  _ __ (_) ___  _ __  ___| |   ");
            Console.WriteLine("| | | | |_     | |   | '_ \\ / _` | '_ ` _ \\| '_ \\| |/ _ \\| '_ \\/ __| |   ");
            Console.WriteLine("| |_| |  _|    | |___| | | | (_| | | | | | | |_) | | (_) | | | \\__ \\_|  ");
            Console.WriteLine(" \\___/|_|       \\____|_| |_|\\__,_|_| |_| |_| .__/|_|\\___/|_| |_|___(_)   ");
            Console.WriteLine("                                           |_|                           ");
            Console.WriteLine("");
            Console.WriteLine("Welcome To The Gladiator Colosseum!");//Prints game name
            Console.WriteLine("");
            Console.WriteLine("The Arena Echoes With The Sound Of Battle, But Today, It’s Not Just Steel That Will Be Tested. ");
            Console.WriteLine("The Crowd Hungers For A Champion, Yet They Wait In Suspense, Watching.");
            Console.WriteLine("Now Is Your Moment! Step Forward, Seize The Advantage, And Make The First Strike.");
            Console.WriteLine("Now You Must Prove Yourself In Battle As A Warrior! As A Champion!!");
            Console.WriteLine("");
            Console.WriteLine("And What Would Your Name Be Gladiator?"); //tells player to choose username
            Console.WriteLine("____________________________________________________________________");

            do
            {


                PlayerCPU playerVsCPU = new PlayerCPU(); // Calls the player and the computer.

                playerVsCPU.TurnChoose();//Chooses who goes first from the player and computer.


                playerVsCPU.PlayerCPURoll();//The player an computers rolling

               
               
                
            }
            while (playerRePlayGame == true);//allows the game to be replayed


           

        }
        
        
    }
}
