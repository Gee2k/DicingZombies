using System;
using System.Collections.Generic;
using UnityEngine;

namespace Base.Assets.Dice
{
    public class Diceable : MonoBehaviour
    {
        private bool _idle;
        private int _sideAmount;

        public Diceable(int sideAmount)
        {
            _sideAmount = sideAmount;
        }

        /*
        * return idle value;
        */
        public bool IsIdle()
        {
            return _idle;
        }
        
        private bool IsSideFacingUp ( Vector3 direction)
        {
            RaycastHit hit;
            Physics.Raycast(transform.position, direction, out hit);
            return hit.transform.tag == "game_ceiling";
        }
        
        public DiceSidesNameEnum GetDiceValue()
        {
            DiceSidesNameEnum currentSideEnum = DiceSidesNameEnum.Unknown;
            
            if (!IsIdle())
            {
                throw new Exception("Dice not ready");
            }

            if (IsSideFacingUp(transform.up))
            {
                currentSideEnum = DiceSidesNameEnum.Ceiling;
            }
            else if (IsSideFacingUp(-transform.up))
            {
                currentSideEnum = DiceSidesNameEnum.Floor;
            }
            else if (IsSideFacingUp(transform.forward))
            {
                currentSideEnum = DiceSidesNameEnum.North;
            }
            else if (IsSideFacingUp(-transform.forward))
            {
                currentSideEnum = DiceSidesNameEnum.South;
            }
            else if (IsSideFacingUp(transform.right))
            {
                currentSideEnum = DiceSidesNameEnum.East;
            }
            else if (IsSideFacingUp(-transform.right))
            {
                currentSideEnum = DiceSidesNameEnum.West;
            }
            return currentSideEnum;
        }
    }
}