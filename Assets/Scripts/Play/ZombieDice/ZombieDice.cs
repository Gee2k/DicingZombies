using System.Collections.Generic;

namespace Play.ZombieDice
{
    public class ZombieDice<T> : Dice<T>
    {
        public ZombieDice(Dictionary<Sides, T> diceSideValues) : base(diceSideValues)
        {
        }
    }
}