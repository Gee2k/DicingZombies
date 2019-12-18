using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZombieDare;

public class HardDice : DiceBehaviour
{
    protected override DiceValues getValueOf(Sides side)
    {
        switch (side)
        {
            case Sides.ceiling:
                return DiceValues.brain;
            case Sides.west:
            case Sides.east:
                return DiceValues.escape;
            default:
                return DiceValues.hit;
        }
    }
}
