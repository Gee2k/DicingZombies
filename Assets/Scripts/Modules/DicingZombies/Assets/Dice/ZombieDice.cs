using System.Collections.Generic;
using Base.Assets.Dice;

namespace Modules.DicingZombies.Assets.Dice
{
    public class ZombieDice : DiceBehaviour<ZombieDiceSideValue>
    {
        public ZombieDice(Dictionary<Sides, ZombieDiceSideValue> diceSideValues) : base(diceSideValues)
        {
        }
    }
}