using GD12_1133_A2_AidenKramer_01;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GD12_1133_A2_AdenKramer_01
{
    internal class PlayerMovement
    {

        internal bool OnRoom = true;

        internal bool moveNorth = false;
        internal bool moveSouth = false;
        internal bool moveEast = false;
        internal bool moveWest = false;

        internal bool wantsToPlay = true;

        internal int movementAxisX = 0;
        internal int movementAxisY = 0;

        internal string? input;

        internal int playerMoving = 0;
        
        internal bool roomChoice = false;
        /* gameMap = new Map();
        int mapSize = 3;
        Rooms[] Rooms;
        
        public class rooms
        {
            Rooms North, East, South, West;
            private int roomNumber;
            public rooms(int num)
            {
                roomNumber = num;
                Console.WriteLine("room" + num, "WWWWW");


            }
            public void SetRooms(Rooms north, Rooms east, Rooms south, Rooms west)
            {
                North = north;
                East = east;
                South = south;
                West = west;

            }




        }
        public Map()
        {
            for(int i = 0; i < Rooms.Length; i++)
            {
                //Rooms[i] = new Rooms(i);

            }
            for (int i = 0; i < Rooms.Length; i++)
            {

               
                Rooms currentroom = Rooms [i];
                Rooms northRoom = null!;
                Rooms eastRoom = null!;
                Rooms southRoom = null!;
                Rooms westRoom = null!;

                currentroom.SetRooms(northRoom, eastRoom, southRoom, westRoom);
            }


        }
        public Rooms FindRoom(int currentroom, int roomTOFind)
        {
            Rooms room = null!;
            if (roomTOFind == 0)
            {
                int northRoomIndex;
                if (currentroom - 3 >= 0)
                {



                }
            }
            else if (roomTOFind == 1)
            {

            }
            else if (roomTOFind == 2)
            {


            }
            else if (roomTOFind == 3)
            {

            }
        }   
        */
            Rooms treasure = new TreasureRoom();
            Rooms treasure2 = new TreasureRoom();
            Rooms treasure3 = new TreasureRoom();
            Rooms treasure4 = new TreasureRoom();
            Rooms combat = new CombatRoom();
            
           
           
            Rooms lore = new LoreRoom();
            Rooms lore2 = new LoreRoom();
            Rooms lore3 = new LoreRoom();
            Rooms lore4 = new LoreRoom();

            internal bool treasureDone = false;
            internal bool treasure2Done = false;
            internal bool treasure3Done = false;
            internal bool treasure4Done = false;
            internal bool combatDone = false;
            
            
           
            internal bool loreDone = false;
            internal bool lore2Done = false;
            internal bool lore3Done = false;
            internal bool lore4Done = false;
            internal bool EnterAndExitRooms = false;
            
            
            
        Rooms[,] grid = new Rooms[3,3];
        public void DisplayRooms()
        {
            Console.WriteLine($"You Are: [{movementAxisY},{movementAxisX}] On The Grid");
            

            
        }
        public void CurrentRooms()
        {
            if (grid[movementAxisY, movementAxisX]!= null )
            {
                Console.WriteLine($"You Are [{movementAxisY},{movementAxisX}] On The Grid");
                

            }
            else
            {

                Console.WriteLine("Cant move there man");
            }
        }


        internal int randomRoom = 0;

        public void AllRoomsRandom()
        {
            
            
                List<Rooms> Rooms = new List<Rooms> { treasure, treasure2, treasure3, treasure4, combat, lore, lore2, lore3, lore4 };
                Random Random = new Random();

                int RandomRoomChoice = Random.Next(0, 9);

                grid[0, 0] = Rooms[Random.Next(Rooms.Count)];
                grid[0, 1] = Rooms[Random.Next(Rooms.Count)];
                grid[0, 2] = Rooms[Random.Next(Rooms.Count)];

                grid[1, 0] = Rooms[Random.Next(Rooms.Count)];
                grid[1, 1] = Rooms[Random.Next(Rooms.Count)];
                grid[1, 2] = Rooms[Random.Next(Rooms.Count)];

                grid[2, 0] = Rooms[Random.Next(Rooms.Count)];
                grid[2, 1] = Rooms[Random.Next(Rooms.Count)];
                grid[2, 2] = Rooms[Random.Next(Rooms.Count)];



                grid[2, 2].On_Room_entered();
                
                grid[2, 2].On_Room_Searched();
                grid[2, 2].On_Room_Exit();
            

        }
        




        internal void RoomError()
        {
            
            RoomRandomChooser();
            RoomLocation();
        }
        internal int RoomRandomChooser()//Chooses the dice for the computer with random.
        {
            Random random = new Random();
            randomRoom = random.Next(1, 9);//Chooses between 4 different dice
            
            return randomRoom;//returns the number that are choosen
        }


        internal void RoomLocation()
        {
            

            


        }
        
        public void Gameloop()
        {
            do
            {

                NoDice();

            }
            while (wantsToPlay == true);

        }
        
        public void NoDice()
        {
            
            DisplayRooms();
            PlayerChoice();
            PlayerMovementChoice();
            ColosseumGrid();
            
            //PlayersMovement();
            CanMove();
        }
        public int PlayerChoice()
        {
            
            Console.WriteLine("you can Go:      North (1)    South(2)      West(3)   and   East(4)");
            input = Console.ReadLine();
            Console.Clear();
            
            return playerMoving;
        }
        public void CanMove()
        {
            CantMoveNorth();
            CantMoveSouth();
            CantMoveEast();
            CantMoveWest();
        }
        internal void CantMoveNorth()
        {
            if (movementAxisY == 1)
            {
                moveNorth = true;
            }
            else
            {
                moveNorth = false;

            }
        }
        internal void CantMoveEast()
        {
            if (movementAxisX == 1)
            {
                moveEast = true;

            }
            else
            {
                moveEast = false;

            }

        }
        internal void CantMoveSouth()
        {
            if (movementAxisY == -1)
            {
                moveSouth = true;

            }
            else
            {
                moveSouth = false;
            }

        }
        internal void CantMoveWest()
        {
            if (movementAxisX == -1)
            {
                moveWest = true;

            }
            else
            {
                moveWest = false;
            }

        }
        public void PlayerMovementChoice()
        {
            if (int.TryParse(input, out int direction))
            {
                switch (direction)
                {
                    case 1:
                        if (CanPlayerMoveNorth()) movementAxisY--;
                        else Console.WriteLine("Moved North!!!!");
                        Console.Clear();
                        break;
                    case 2:
                        if (CanPlayerMoveSouth()) movementAxisY++;
                        else Console.WriteLine("Moved South!!!!");
                        Console.Clear();
                        break;
                    case 3:
                        if (CanPlayerMoveWest()) movementAxisX--;
                        else Console.WriteLine("Moved West!!!!");
                        Console.Clear();
                        break;
                    case 4:
                        if (CanPlayerMoveEast()) movementAxisX++;
                        else Console.WriteLine("Moved East!!!!");
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Cant Go That Direction");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Type any number from 1-4");
                NoDice();
            }




        }
        public bool CanPlayerMoveNorth() => movementAxisY > 0;
        public bool CanPlayerMoveEast() => movementAxisX < 2;
        public bool CanPlayerMoveSouth() => movementAxisY < 2;
        public bool CanPlayerMoveWest() => movementAxisX > 0;

        GameManager manager = new GameManager();
        public void ColosseumGrid()
        {
            colosseumTopLeftSide();
            colosseumTopMiddleSide();
            colosseumTopRightSide();

            colosseumMiddleLeftSide();
            colosseumMiddleMiddleSide();
            colosseumMiddleRightSide();

            colosseumBottomLeftSide();
            colosseumBottomMiddleSide();
            colosseumBottomRightSide();
        }
        internal void colosseumTopLeftSide()
        {
            if (movementAxisY == 0 && movementAxisX == 0)
            {
                Console.WriteLine(@"           
                                    ███████████████████████████████                                  
                             █████████████                   █████████████                             
                       █████████||                                  ||█████████                       
                    ██████      ||                                  ||       ██████                    
                 ██████         ||                                  ||          ██████                 
               ████             ||                                  ||              ████               
             ████               ||                                  ||                █████            
           ████		You	||		  		    ||			████
         ████                   ||                                  ||                    ████         
        ████                    ||                                  ||                     ████        
       ███                      ||                                  ||                       ███       
      ███_______________________||__________________________________||________________________███      
      ███                       ||                                  ||                        ███      
      ███                       ||                                  ||                        ███      
      ███			||		 		    ||			      ███      
      ███                       ||                                  ||                        ███      
      ███                       ||                                  ||                        ███      
      ███_______________________||__________________________________||________________________███      
       ███                      ||                                  ||                       ███       
        ████                    ||                                  ||                     ████        
         ████			||		 	            ||			 ████         
           ████                 ||                                  ||                 ████           
             ████               ||                                  ||               █████            
               ████             ||                                  ||             ████               
                 ██████         ||                                  ||          ██████                 
                    ██████      ||                                  ||       ██████                    
                       █████████||                                  || █████████                       
                             ████████████                   ████████████                             
                                  ████████████████████████████████       ");
                RoomRandomChooser();
                RoomLocation();
                AllRoomsRandom();

            }
        }
        internal void colosseumTopMiddleSide()
        {
            if (movementAxisY == 0 && movementAxisX == 1)
            {
                Console.WriteLine(@"
                                    ███████████████████████████████                                  
                             █████████████                   █████████████                             
                       █████████||                                  ||█████████                       
                    ██████      ||                                  ||       ██████                    
                 ██████         ||                                  ||          ██████                 
               ████             ||                                  ||              ████               
             ████               ||                                  ||                █████            
           ████			||		You		    ||			████
         ████                   ||                                  ||                    ████         
        ████                    ||                                  ||                     ████        
       ███                      ||                                  ||                       ███       
      ███_______________________||__________________________________||________________________███      
      ███                       ||                                  ||                        ███      
      ███                       ||                                  ||                        ███      
      ███			||		 		    ||			      ███      
      ███                       ||                                  ||                        ███      
      ███                       ||                                  ||                        ███      
      ███_______________________||__________________________________||________________________███      
       ███                      ||                                  ||                       ███       
        ████                    ||                                  ||                     ████        
         ████			||		 	            ||			 ████         
           ████                 ||                                  ||                 ████           
             ████               ||                                  ||               █████            
               ████             ||                                  ||             ████               
                 ██████         ||                                  ||          ██████                 
                    ██████      ||                                  ||       ██████                    
                       █████████||                                  || █████████                       
                             ████████████                   ████████████                             
                                  ████████████████████████████████  ");
                RoomRandomChooser();
                RoomLocation();
                AllRoomsRandom();
            }
        }
        internal void colosseumTopRightSide()
        {
            if (movementAxisY == 0 && movementAxisX == 2)
            {
                Console.WriteLine(@"
                                    ███████████████████████████████                                  
                             █████████████                   █████████████                             
                       █████████||                                  ||█████████                       
                    ██████      ||                                  ||       ██████                    
                 ██████         ||                                  ||          ██████                 
               ████             ||                                  ||              ████               
             ████               ||                                  ||                █████            
           ████			||				    ||	You		████
         ████                   ||                                  ||                    ████         
        ████                    ||                                  ||                     ████        
       ███                      ||                                  ||                       ███       
      ███_______________________||__________________________________||________________________███      
      ███                       ||                                  ||                        ███      
      ███                       ||                                  ||                        ███      
      ███			||		 		    ||			      ███      
      ███                       ||                                  ||                        ███      
      ███                       ||                                  ||                        ███      
      ███_______________________||__________________________________||________________________███      
       ███                      ||                                  ||                       ███       
        ████                    ||                                  ||                     ████        
         ████			||		 	            ||			 ████         
           ████                 ||                                  ||                 ████           
             ████               ||                                  ||               █████            
               ████             ||                                  ||             ████               
                 ██████         ||                                  ||          ██████                 
                    ██████      ||                                  ||       ██████                    
                       █████████||                                  || █████████                       
                             ████████████                   ████████████                             
                                  ████████████████████████████████");
                RoomRandomChooser();
                RoomLocation();
                AllRoomsRandom();
            }
        }




        internal void colosseumMiddleLeftSide()
        {
            if (movementAxisY == 1 && movementAxisX == 0)
            {
                Console.WriteLine(@"
                                    ███████████████████████████████                                  
                             █████████████                   █████████████                             
                       █████████||                                  ||█████████                       
                    ██████      ||                                  ||       ██████                    
                 ██████         ||                                  ||          ██████                 
               ████             ||                                  ||              ████               
             ████               ||                                  ||                █████            
           ████			||				    ||			████
         ████                   ||                                  ||                    ████         
        ████                    ||                                  ||                     ████        
       ███                      ||                                  ||                       ███       
      ███_______________________||__________________________________||________________________███      
      ███                       ||                                  ||                        ███      
      ███                       ||                                  ||                        ███      
      ███		You	||		 		    ||			      ███      
      ███                       ||                                  ||                        ███      
      ███                       ||                                  ||                        ███      
      ███_______________________||__________________________________||________________________███      
       ███                      ||                                  ||                       ███       
        ████                    ||                                  ||                     ████        
         ████			||		 	            ||			 ████         
           ████                 ||                                  ||                 ████           
             ████               ||                                  ||               █████            
               ████             ||                                  ||             ████               
                 ██████         ||                                  ||          ██████                 
                    ██████      ||                                  ||       ██████                    
                       █████████||                                  || █████████                       
                             ████████████                   ████████████                             
                                  ████████████████████████████████");
                RoomRandomChooser();
                RoomLocation();
                AllRoomsRandom();
            }
        }
        internal void colosseumMiddleMiddleSide()
        {
            if (movementAxisY == 1 && movementAxisX == 1)
            {
                Console.WriteLine(@"
                                    ███████████████████████████████                                  
                             █████████████                   █████████████                             
                       █████████||                                  ||█████████                       
                    ██████      ||                                  ||       ██████                    
                 ██████         ||                                  ||          ██████                 
               ████             ||                                  ||              ████               
             ████               ||                                  ||                █████            
           ████			||				    ||			████
         ████                   ||                                  ||                    ████         
        ████                    ||                                  ||                     ████        
       ███                      ||                                  ||                       ███       
      ███_______________________||__________________________________||________________________███      
      ███                       ||                                  ||                        ███      
      ███                       ||                                  ||                        ███      
      ███			||		 	You	    ||			      ███      
      ███                       ||                                  ||                        ███      
      ███                       ||                                  ||                        ███      
      ███_______________________||__________________________________||________________________███      
       ███                      ||                                  ||                       ███       
        ████                    ||                                  ||                     ████        
         ████			||		 	            ||			 ████         
           ████                 ||                                  ||                 ████           
             ████               ||                                  ||               █████            
               ████             ||                                  ||             ████               
                 ██████         ||                                  ||          ██████                 
                    ██████      ||                                  ||       ██████                    
                       █████████||                                  || █████████                       
                             ████████████                   ████████████                             
                                  ████████████████████████████████");
                RoomRandomChooser();
                RoomLocation();
                AllRoomsRandom();
            }
        }
        internal void colosseumMiddleRightSide()
        {
            if (movementAxisY == 1 && movementAxisX == 2)
            {
                Console.WriteLine(@"
                                    ███████████████████████████████                                  
                             █████████████                   █████████████                             
                       █████████||                                  ||█████████                       
                    ██████      ||                                  ||       ██████                    
                 ██████         ||                                  ||          ██████                 
               ████             ||                                  ||              ████               
             ████               ||                                  ||                █████            
           ████			||				    ||			████
         ████                   ||                                  ||                    ████         
        ████                    ||                                  ||                     ████        
       ███                      ||                                  ||                       ███       
      ███_______________________||__________________________________||________________________███      
      ███                       ||                                  ||                        ███      
      ███                       ||                                  ||                        ███      
      ███			||		 		    ||		You	      ███      
      ███                       ||                                  ||                        ███      
      ███                       ||                                  ||                        ███      
      ███_______________________||__________________________________||________________________███      
       ███                      ||                                  ||                       ███       
        ████                    ||                                  ||                     ████        
         ████			||		 	            ||			 ████         
           ████                 ||                                  ||                 ████           
             ████               ||                                  ||               █████            
               ████             ||                                  ||             ████               
                 ██████         ||                                  ||          ██████                 
                    ██████      ||                                  ||       ██████                    
                       █████████||                                  || █████████                       
                             ████████████                   ████████████                             
                                  ████████████████████████████████");
                RoomRandomChooser();
                RoomLocation();
                AllRoomsRandom();
            }
        }




        internal void colosseumBottomLeftSide()
        {
            if (movementAxisY == 2 && movementAxisX == 0)
            {
                Console.WriteLine(@"
'                                   ███████████████████████████████                                  
                             █████████████                   █████████████                             
                       █████████||                                  ||█████████                       
                    ██████      ||                                  ||       ██████                    
                 ██████         ||                                  ||          ██████                 
               ████             ||                                  ||              ████               
             ████               ||                                  ||                █████            
           ████			||				    ||			████
         ████                   ||                                  ||                    ████         
        ████                    ||                                  ||                     ████        
       ███                      ||                                  ||                       ███       
      ███_______________________||__________________________________||________________________███      
      ███                       ||                                  ||                        ███      
      ███                       ||                                  ||                        ███      
      ███			||		 		    ||			      ███      
      ███                       ||                                  ||                        ███      
      ███                       ||                                  ||                        ███      
      ███_______________________||__________________________________||________________________███      
       ███                      ||                                  ||                       ███       
        ████                    ||                                  ||                     ████        
         ████		You	||		 	            ||			 ████         
           ████                 ||                                  ||                 ████           
             ████               ||                                  ||               █████            
               ████             ||                                  ||             ████               
                 ██████         ||                                  ||          ██████                 
                    ██████      ||                                  ||       ██████                    
                       █████████||                                  || █████████                       
                             ████████████                   ████████████                             
                                  ████████████████████████████████");
                RoomRandomChooser();
                RoomLocation();
                AllRoomsRandom();
            }
        }
        internal void colosseumBottomMiddleSide()
        {
            if (movementAxisY == 2 && movementAxisX == 1)
            {
                Console.WriteLine(@"
                                    ███████████████████████████████                                  
                             █████████████                   █████████████                             
                       █████████||                                  ||█████████                       
                    ██████      ||                                  ||       ██████                    
                 ██████         ||                                  ||          ██████                 
               ████             ||                                  ||              ████               
             ████               ||                                  ||                █████            
           ████			||				    ||			████
         ████                   ||                                  ||                    ████         
        ████                    ||                                  ||                     ████        
       ███                      ||                                  ||                       ███       
      ███_______________________||__________________________________||________________________███      
      ███                       ||                                  ||                        ███      
      ███                       ||                                  ||                        ███      
      ███			||		 		    ||			      ███      
      ███                       ||                                  ||                        ███      
      ███                       ||                                  ||                        ███      
      ███_______________________||__________________________________||________________________███      
       ███                      ||                                  ||                       ███       
        ████                    ||                                  ||                     ████        
         ████			||		 You	            ||		           ████         
           ████                 ||                                  ||                 ████           
             ████               ||                                  ||               █████            
               ████             ||                                  ||             ████               
                 ██████         ||                                  ||          ██████                 
                    ██████      ||                                  ||       ██████                    
                       █████████||                                  || █████████                       
                             ████████████                   ████████████                             
                                  ████████████████████████████████");
                RoomRandomChooser();
                RoomLocation();
                AllRoomsRandom();
            }
        }
        internal void colosseumBottomRightSide()
        {
            if (movementAxisY == 2 && movementAxisX == 2)
            {
                Console.WriteLine(@"
                                    ███████████████████████████████                                  
                             █████████████                   █████████████                             
                       █████████||                                  ||█████████                       
                    ██████      ||                                  ||       ██████                    
                 ██████         ||                                  ||          ██████                 
               ████             ||                                  ||              ████               
             ████               ||                                  ||                █████            
           ████			||				    ||			████
         ████                   ||                                  ||                    ████         
        ████                    ||                                  ||                     ████        
       ███                      ||                                  ||                       ███       
      ███_______________________||__________________________________||________________________███      
      ███                       ||                                  ||                        ███      
      ███                       ||                                  ||                        ███      
      ███			||		 		    ||			      ███      
      ███                       ||                                  ||                        ███      
      ███                       ||                                  ||                        ███      
      ███_______________________||__________________________________||________________________███      
       ███                      ||                                  ||                       ███       
        ████                    ||                                  ||                     ████        
         ████			||		 	            ||	You		 ████         
           ████                 ||                                  ||                 ████           
             ████               ||                                  ||               █████            
               ████             ||                                  ||             ████               
                 ██████         ||                                  ||          ██████                 
                    ██████      ||                                  ||       ██████                    
                       █████████||                                  || █████████                       
                             ████████████                   ████████████                             
                                  ████████████████████████████████");
                RoomRandomChooser();
                RoomLocation();
                AllRoomsRandom();
            }
        }







    }
}
