using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class Dice<T> : MonoBehaviour
{
    private Dictionary<Sides, T> diceSideValues;
    
    protected bool Idle;

    protected Dice(Dictionary<Sides, T> diceSideValues)
    {
        this.diceSideValues = diceSideValues;
    }

    /*
     * return idle value;
     */
    protected bool IsIdle()
    {
        return Idle;
    }
    
    private bool IsSideFacingUp ( Vector3 direction)
    {
        RaycastHit hit;
        Physics.Raycast(transform.position, direction, out hit);
        return hit.transform.tag == "game_ceiling";
    }
    
    protected T GetDiceValue()
    {
        Sides currentSide = Sides.Unknown;
        
        if (!Idle)
        {
            throw new Exception("Dice not ready");
        }

        if (IsSideFacingUp(transform.up))
        {
            currentSide = Sides.Ceiling;
        }
        else if (IsSideFacingUp(-transform.up))
        {
            currentSide = Sides.Floor;
        }
        else if (IsSideFacingUp(transform.forward))
        {
            currentSide = Sides.North;
        }
        else if (IsSideFacingUp(-transform.forward))
        {
            currentSide = Sides.South;
        }
        else if (IsSideFacingUp(transform.right))
        {
            currentSide = Sides.East;
        }
        else if (IsSideFacingUp(-transform.right))
        {
            currentSide = Sides.West;
        }
        return diceSideValues[currentSide];
    }
}