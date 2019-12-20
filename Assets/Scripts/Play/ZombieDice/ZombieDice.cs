using System.Collections.Generic;

namespace Play.ZombieDice
{
    public class ZombieDice : Dice<ZombieDiceSideValue>
    {
        public ZombieDice(Dictionary<Sides, ZombieDiceSideValue> diceSideValues) : base(diceSideValues)
        {
        }
    }
}