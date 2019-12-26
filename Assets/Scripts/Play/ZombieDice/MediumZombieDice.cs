using System.Collections.Generic;

namespace Play.ZombieDice
{
    public class MediumZombieDice : ZombieDice
    {
        private MediumZombieDice() : base(new Dictionary<Sides, ZombieDiceSideValue>
        {
            [Sides.Ceiling] = new ZombieDiceSideValue(ZombieDiceSideColorEnum.Yellow, ZombieDiceValueEnum.Hit),
            [Sides.Floor] = new ZombieDiceSideValue(ZombieDiceSideColorEnum.Yellow, ZombieDiceValueEnum.Hit),
            [Sides.East] = new ZombieDiceSideValue(ZombieDiceSideColorEnum.Yellow, ZombieDiceValueEnum.Brain),
            [Sides.West] = new ZombieDiceSideValue(ZombieDiceSideColorEnum.Yellow, ZombieDiceValueEnum.Brain),
            [Sides.North] = new ZombieDiceSideValue(ZombieDiceSideColorEnum.Yellow, ZombieDiceValueEnum.Escape),
            [Sides.South] = new ZombieDiceSideValue(ZombieDiceSideColorEnum.Yellow, ZombieDiceValueEnum.Escape),
        }
        )
        {

        }
    }
}