using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZombieDare;

public class MediumDice : DiceBehaviour
{
    protected override DiceValues getValueOf(Sides side)
    {
        switch (side)
        {
            case Sides.ceiling:
            case Sides.floor:
                return DiceValues.hit;
            case Sides.west:
            case Sides.east:
                return DiceValues.escape;
            default:
                return DiceValues.brain;
        }
    }
}
