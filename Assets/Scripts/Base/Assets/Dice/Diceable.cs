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
        
        public SidesEnum GetDiceValue()
        {
            SidesEnum currentSideEnum = SidesEnum.Unknown;
            
            if (!IsIdle())
            {
                throw new Exception("Dice not ready");
            }

            if (IsSideFacingUp(transform.up))
            {
                currentSideEnum = SidesEnum.Ceiling;
            }
            else if (IsSideFacingUp(-transform.up))
            {
                currentSideEnum = SidesEnum.Floor;
            }
            else if (IsSideFacingUp(transform.forward))
            {
                currentSideEnum = SidesEnum.North;
            }
            else if (IsSideFacingUp(-transform.forward))
            {
                currentSideEnum = SidesEnum.South;
            }
            else if (IsSideFacingUp(transform.right))
            {
                currentSideEnum = SidesEnum.East;
            }
            else if (IsSideFacingUp(-transform.right))
            {
                currentSideEnum = SidesEnum.West;
            }
            return currentSideEnum;
        }
    }
}