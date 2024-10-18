using GD12_1133_A2_AidenKramer_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GD12_1133_A2_AdenKramer_01
{
    internal class ItemCalling
    {
        //Weapons 

        internal int treasureScore;
        internal int TimesRoomIsSearched;

        Item SwordS = new ShortSword();
        Item SwordM = new LongSword();
        Item SwordL = new GreatSword();
        Item SwordXL = new ColossalSword();
        
        //Healing pot
        Item HealingItem = new HealingPotion();

        //HealingPotion Amount and how many we will start with..
        public int HealingAmount = 1;
        public int HealingPot = 0;

        //Lists for HealingAmount' and for HealingPot'
        public List<int>HealingAmountList = new List<int>();
        public List<Item> HealingPotList = new List<Item>();

        //Weapons Amount and how many we will start with..
        public int WeaponAmount = 4;
        public int WeaponsInInv = 0;

        //Lists for Weapon Amount' and for Weapons to start with
        public List<int> WeaponAmountList = new List<int>();
        public List<Item> WeaponsInInvList = new List<Item>();




        public void Randomizer()
        {
            if (TimesRoomIsSearched < 1)
            {
                Console.WriteLine("you Searched this room already");



                if (treasureScore > 9)
                {
                    Console.WriteLine("You Found A Strange Item?......");
                    Console.WriteLine(" *Insane Drop* ");
                    WeaponsInInvList.Add(SwordXL);
                    WeaponsInInv++;
                    WeaponAmountList.Add(WeaponsInInv);
                }
                else if (treasureScore > 7)
                {
                    Console.WriteLine("You Found A Strange Item?......");
                    Console.WriteLine(" *Ultra Drop* ");
                    WeaponsInInvList.Add(SwordL);
                    WeaponsInInv++;
                    WeaponAmountList.Add(WeaponsInInv);
                }
                else if (treasureScore > 5)
                {
                    Console.WriteLine("You Found A Strange Item?......");
                    Console.WriteLine(" *Rare Drop*  ");
                    WeaponsInInvList.Add(SwordM);
                    WeaponsInInv++;
                    WeaponAmountList.Add(WeaponsInInv);
                }
                else if (treasureScore > 3)
                {
                    Console.WriteLine("You Found A Strange Item?......");
                    Console.WriteLine(" *Common Drop* ");
                    WeaponsInInvList.Add(SwordS);
                    WeaponsInInv++;
                    WeaponAmountList.Add(WeaponsInInv);


                }
                else if (treasureScore > 0)
                {
                    Console.WriteLine("You Found A Strange Item?......");
                    Console.WriteLine(" *Super Common Drop* ");
                    HealingPotList.Add(HealingItem);
                    HealingPot++;
                    HealingAmountList.Add(HealingAmount);

                }
                TimesRoomIsSearched++;

                //InventoryDisplay();




            }
            return;

        }
        public void InitialInventory()
        {
            WeaponsInInvList.Add(SwordS);
            HealingPotList.Add(HealingItem);
            
        }
        public void ItemRandomizer()
        {
            Random random = new Random();



            int randomWeapon = random.Next(0, WeaponAmount);
            switch (randomWeapon)
            {
                case (int)Items.SwordS:

                    WeaponsInInvList.Add(SwordS);//Adds SwordS to list
                    WeaponAmount++;//adds 1 weapon amount 
                    WeaponAmountList.Add(WeaponAmount);//Adding number to bve stored in weapon amount list

                    break;

                case (int)Items.SwordM://Same thing for the next 3

                    WeaponsInInvList.Add(SwordM);
                    WeaponAmount++;
                    WeaponAmountList.Add(WeaponAmount);

                    break;

                case (int)Items.SwordL:

                    WeaponsInInvList.Add(SwordL);
                    WeaponAmount++;
                    WeaponAmountList.Add(WeaponAmount);

                    break;

                case (int)Items.SwordXL:

                    WeaponsInInvList.Add(SwordXL);
                    WeaponAmount++;
                    WeaponAmountList.Add(WeaponAmount);

                    break;
                case (int)Items.HealingItem:

                    HealingPotList.Add(HealingItem);
                    HealingAmount++;
                    HealingAmountList.Add(HealingAmount);

                    break;

            }
        }

    }

    
    
}
