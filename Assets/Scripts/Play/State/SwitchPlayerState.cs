using Game.State;
using UnityEngine;

namespace Play.State
{
    public class SwitchPlayerState : IGameState
    {
        private RollDiceState rollDiceState;

        public IGameState update()
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