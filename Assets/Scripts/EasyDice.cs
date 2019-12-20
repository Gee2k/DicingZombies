using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyDice : DiceBehaviour
{
    protected override DiceValues getValueOf(Sides side)
    {
        switch(side)
        {
            case Sides.ceiling:
                return DiceValues.hit;
            case Sides.west:
            case Sides.east:
                return DiceValues.escape;
            default:
                return DiceValues.brain;
        }
    }
}
