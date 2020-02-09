using System.Collections.Generic;
using Game.Assets.Dice;

namespace Play.DicingZombies.Assets.Dice
{
    public class ZombieDice : Dice<ZombieDiceSideValue>
    {
        public ZombieDice(Dictionary<Sides, ZombieDiceSideValue> diceSideValues) : base(diceSideValues)
        {
        }
    }
}