using System.Collections;
using System.Collections.Generic;
using Base.Assets.Dice;
using UnityEngine;

namespace Base
{
    public class DiceEmitter<T> : MonoBehaviour
    {
        Vector3 pos = new Vector3(0, 0, 0);

        private List<GameObject> _dices = new List<GameObject>();

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

        private bool checkDice()
        {
            bool idle = true;
            foreach (GameObject dice in _dices)
            {
                idle = idle && dice.GetComponent<Diceable>().IsIdle();
            }

            return idle;
        }

        public void ThrowDices(List<IDice<T>> dices)
        {
            throwFinished = false;

            foreach (IDice<T> dice in dices)
            {
                _dices.Add(dice.GetRepresentation());
                Instantiate(dice.GetRepresentation(), pos, Quaternion.identity);
            }
        }
    }
}