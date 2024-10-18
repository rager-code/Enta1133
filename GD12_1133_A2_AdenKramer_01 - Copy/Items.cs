using GD12_1133_A2_AdenKramer_01;
using GD12_1133_A2_AidenKramer_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD12_1133_A2_AdenKramer_01
{
    public abstract class Item
    {
        public abstract int Damage { get; }
        

        public abstract int Durrability { get; }
        

        public abstract string? Name { get; }
        
    }
}       
public class ShortSword : Item
{
    public override int Damage { get; } = 30;
    

    public override int Durrability { get; } = 1;
    

    public override string? Name { get; } = "ShortSword";
    


}
public class LongSword : Item
{

    public override int Damage { get; } = 50;


    public override int Durrability { get; } = 1;


    public override string? Name { get; } = "LongSword";

}
public class GreatSword : Item
{

    public override int Damage { get; } = 70;


    public override int Durrability { get; } = 1;


    public override string? Name { get; } = "GreatSword";

}
public class ColossalSword: Item
{

    public override int Damage { get; } = 90;


    public override int Durrability { get; } = 1;


    public override string? Name { get; } = "ColossalSword";

}
public class HealingPotion : Item
{

    public override int Damage { get; } = 0;


    public override int Durrability { get; } = 1;


    public override string? Name { get; } = "HealingPotion";





}
