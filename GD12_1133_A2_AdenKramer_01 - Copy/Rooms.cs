using GD12_1133_A2_AidenKramer_01;
using System.ComponentModel.Design;
using System.Net.Security;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace GD12_1133_A2_AdenKramer_01
{
    
    
    public abstract class Rooms
    {
        public string? Name { get; set; }

        internal bool CombatRoomOpened = false;
        internal bool TreasureRoomSearched = false;
        internal bool TreasureRoomOpened = false;
        internal bool rolledD10 = false;
        internal int treasureRolls = 0;
        internal int treasureScore = 0;
        internal int TimesRoomIsSearched = 0;

        
        
        internal int RoomsSearched()
        {
            

            if (TreasureRoomSearched == true)
            {
                Console.WriteLine("-Room Searched-");
                
            }
            else if (TreasureRoomSearched == false)
            {

                if (TimesRoomIsSearched > 1)
                {
                    Console.WriteLine("you Searched this room already");

                }

                TimesRoomIsSearched++;

            }

            return TimesRoomIsSearched;
        }
        internal int TreasureRolling()
        {
            Random random = new Random();
            treasureRolls = random.Next(1, 1);//Chooses between 4 different dice

            return treasureRolls;

        }
        internal int TreasureDice()
        {
            DiceRoller sixSides = new DiceRoller();

            sixSides.countSide = 10;


            if (treasureRolls == 1) //If dicepicker is 1 then roll a D10.
            {
                if (rolledD10 == false)//checks if this dice has alreay been rolled
                {   
                    
                    Console.WriteLine("You Notice Your Opponent Is Looking Into The Crowd, Only Able To Hear The Cheers, He Doesnt Notice That You Snuck Up Behind Him And Went For A BackStab, You Stabbed Him In His Neck, He Falls To His Knees And Drops His Weapon....");
                    
                    treasureScore = sixSides.Roll();


                    rolledD10 = true;
                }
                
            }
            return treasureRolls;
        }

        public virtual void On_Room_entered()//New can delete 
        {
            
            
        }

        public virtual void On_Room_Searched()
        {

            

        }

        public virtual void On_Room_Exit()
        {
            

        }

    }

    public class TreasureRoom : Rooms
    {
        public string? Name { get; set; }

        public override void On_Room_entered()//New can delete 
        {
            Console.WriteLine("Room Entered");
            Console.WriteLine("you are in the Treasure Room");

            

            if (TreasureRoomOpened == false)//checks if this dice has alreay been rolled
            {
                
                
                RoomsSearched();



                TreasureRoomOpened = true;
            }

            

        }




        public override void On_Room_Searched()
        {
            TreasureRolling();
            TreasureDice();
            
            ItemCalling randomizer = new ItemCalling(); 
            randomizer.Randomizer();


            {
                if (TimesRoomIsSearched == 1)
                {
                    Console.WriteLine("you Searched this room already");



                    if (treasureScore > 9)
                    {
                        Console.WriteLine("You Found A Strange Item?......");
                        Console.WriteLine(" *Insane Drop* Spear *****");
                        
                    }
                    else if (treasureScore > 7)
                    {
                        Console.WriteLine("You Found A Strange Item?......");
                        Console.WriteLine(" *Ultra Drop* Gladius ****");
                        
                    }
                    else if (treasureScore > 5)
                    {
                        Console.WriteLine("You Found A Strange Item?......");
                        Console.WriteLine(" *Rare Drop* Honshu *** ");
                        
                    }
                    else if (treasureScore > 3)
                    {
                        Console.WriteLine("You Found A Strange Item?......");
                        Console.WriteLine(" *Common Drop* Retes ** ");
                        


                    }
                    else if (treasureScore > 0)
                    {
                        Console.WriteLine("You Found A Strange Item?......");
                        Console.WriteLine(" *Super Common Drop* Healing Potion *");
                        

                    }
                    TimesRoomIsSearched++;

                    InventoryDisplay();




                }
                return;

            }



            //rolls dice for item
            //rolls 10 die 
            // if 3 > then you get a greatsword 
            // if < 7 then you get a potion 


        }
        

        public void ItemUse()
        {
            

                    
                


        }
        public void InventoryDisplay()
        {
            
        }
        public override void On_Room_Exit()
        {
           
                if (TreasureRoomOpened == false)//checks if this dice has alreay been rolled
                {
                    
                    Console.WriteLine("Room Closed");
                    
                    


                    TreasureRoomOpened = true;
                }
                
            
            
            //bool to not run room reload room when re entered

            //Enter roomtreasure == true
            //room treasure == false
        }
    }
    public class CombatRoom : Rooms
    {
        public string? Name { get; set; }
        public override void On_Room_entered()//New can delete 
        {
            Console.WriteLine("you are in a combat zone!");
            Console.WriteLine("ARE YOU Ready?!!");
            PlayerCPU playerVsCPU = new PlayerCPU(); // Calls the player and the computer.
            playerVsCPU.TurnChoose(); //Chooses who goes first from the player and computer.
            playerVsCPU.PlayerCPURoll();
            //CombatRoomSearched();
        }
        public override void On_Room_Searched()
        {













        }
        





           
        
            
            
            
            
            
            //InitialInventory()



                /*if (TreasureRoomOpened == false)//checks if this dice has alreay been rolled
            {
                Console.WriteLine("           ,  /\\  .  ");
                Console.WriteLine("          //`-||-'\\ ");
                Console.WriteLine("         (| -=||=- |)");
                Console.WriteLine("          \\,-||-.// ");
                Console.WriteLine("           `  ||  '  ");
                Console.WriteLine("              ||     ");
                Console.WriteLine("              ||     ");
                Console.WriteLine("              ||     ");
                Console.WriteLine("              ||     ");
                Console.WriteLine("              ||     ");
                Console.WriteLine("              ()");
                Console.WriteLine("Room Entered");




                TreasureRoomOpened = true;
            }
        }}*/
        public override void On_Room_Exit()
        {
            if (CombatRoomOpened == false)//checks if this dice has alreay been rolled
            {
                
                Console.WriteLine("Room Shut");




                CombatRoomOpened = true;
            }
        } 
    
    }
    public class LoreRoom : Rooms
    {
        public string? Name { get; set; }
        public override void On_Room_entered()//New can delete 
        {
            Console.WriteLine("The Collosseume Rumbles, You Get Startled And Drop Your Sword..... ");
            Console.WriteLine("Pick Your Sword Back Up And Fight !");

        }

        public override void On_Room_Searched()
        {
            Console.WriteLine("You Can Not Be Defeated This Easily Warrior!");
        }

        public override void On_Room_Exit()
        {
            Console.WriteLine("Find Better Weapons on the Ground They Are All Scattered!");
        }
        

    
    }

}
    //protected void OnRoomEntered()

    //Console.WriteLine(1);





    //protected void OnRoomSearched()

    //Console.WriteLine(2);





    //protected void OnRoomExit()

    //Console.WriteLine(3);
    //public interface Rooms
    //{
        //internal int roomNumbers = 9;
        //internal int RoomNumberChooser()//Chooses the dice for the computer with random.
        //{
            //Random random = new Random();
            //roomNumbers = random.Next(1, 10);//Chooses between 4 different dice

            //return roomNumbers;//returns the number that are choosen
        //}
    //}
//}
