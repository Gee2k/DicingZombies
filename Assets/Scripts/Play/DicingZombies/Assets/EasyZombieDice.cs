using System.Collections.Generic;
using Play.DicingZombies.Assets.Dice;

namespace Play.DicingZombies
{
    public class EasyZombieDice : ZombieDice
    {
        private EasyZombieDice() : base(new Dictionary<Sides, ZombieDiceSideValue>
        {
            [Sides.Ceiling] = new ZombieDiceSideValue(ZombieDiceSideColorEnum.Green, ZombieDiceValueEnum.Hit),
            [Sides.Floor] = new ZombieDiceSideValue(ZombieDiceSideColorEnum.Green, ZombieDiceValueEnum.Brain),
            [Sides.East] = new ZombieDiceSideValue(ZombieDiceSideColorEnum.Green, ZombieDiceValueEnum.Brain),
            [Sides.West] = new ZombieDiceSideValue(ZombieDiceSideColorEnum.Green, ZombieDiceValueEnum.Brain),
            [Sides.North] = new ZombieDiceSideValue(ZombieDiceSideColorEnum.Green, ZombieDiceValueEnum.Escape),
            [Sides.South] = new ZombieDiceSideValue(ZombieDiceSideColorEnum.Green, ZombieDiceValueEnum.Escape),
        }
        )
        {

        }
    }
}