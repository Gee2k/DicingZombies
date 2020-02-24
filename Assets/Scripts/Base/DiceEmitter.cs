using System.Collections;
using System.Collections.Generic;
using Base.Assets.Dice;
using UnityEngine;

namespace Base
{
    public class DiceEmitter<T> : MonoBehaviour
    {
        Vector3 pos = new Vector3(0, 0, 0);

        private List<IDice<T>> _dices = new List<IDice<T>>();
        private List<DiceSidesNameEnum> _diceResults = new List<DiceSidesNameEnum>();

        private bool throwFinished = false;

        void Update()
        {
            if (checkDice())
            {
                Debug.Log("[DiceEmitter] roll finished");
            }
            else
            {
                Debug.Log("[DiceEmitter] roll in progress");
            }
        }

        /**
         * checks if a dice throw is finished
         * then sets the result in the parent dice
         */
        private bool checkDice()
        {
            bool idle = true;
            foreach (IDice<T> dice in _dices)
            {
                idle = idle && dice.GetRepresentation().GetComponent<Diceable>().IsIdle();
            }

            if (idle)
            {
                foreach (IDice<T> dice in _dices)
                {
                    dice.SetDiceThrowResult(dice.GetRepresentation().GetComponent<Diceable>().GetDiceValue());
                }
            }

            return idle;
        }

        public void ThrowDices(List<IDice<T>> dices)
        {
            throwFinished = false;
            _dices = dices;
            // foreach (IDice<T> dice in dices)
            foreach (IDice<T> dice in _dices)
            {
                Instantiate(dice.GetRepresentation(), pos, Quaternion.identity);
            }
        }
    }
}