using Game.State;
using UnityEngine;

namespace Play.State
{
    public class SwitchPlayerState : GameState
    {
        private RollDiceState rollDiceState;

        public override GameState update()
        {

            Debug.Log("[SwitchPlayerState] inside");
            return rollDiceState;
        }

        public void setRollDiceState(RollDiceState gameState)
        {
            this.rollDiceState = gameState;
        }
    }
}