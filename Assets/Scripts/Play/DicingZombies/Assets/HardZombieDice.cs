using System.Collections.Generic;
using Play.DicingZombies.Assets.Dice;

namespace Play.DicingZombies
{
    public class HardZombieDice : ZombieDice
    {
        private HardZombieDice() : base(new Dictionary<Sides, ZombieDiceSideValue>
        {
            [Sides.Ceiling] = new ZombieDiceSideValue(ZombieDiceSideColorEnum.Red, ZombieDiceValueEnum.Brain),
            [Sides.Floor] = new ZombieDiceSideValue(ZombieDiceSideColorEnum.Red, ZombieDiceValueEnum.Hit),
            [Sides.East] = new ZombieDiceSideValue(ZombieDiceSideColorEnum.Red, ZombieDiceValueEnum.Hit),
            [Sides.West] = new ZombieDiceSideValue(ZombieDiceSideColorEnum.Red, ZombieDiceValueEnum.Hit),
            [Sides.North] = new ZombieDiceSideValue(ZombieDiceSideColorEnum.Red, ZombieDiceValueEnum.Escape),
            [Sides.South] = new ZombieDiceSideValue(ZombieDiceSideColorEnum.Red, ZombieDiceValueEnum.Escape),
        }
        )
        {

        }
    }
}