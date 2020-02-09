using Game.State;
using UnityEngine;

namespace Play.DicingZombies.State
{
    public class SwitchPlayerState : GenericGameState, IGameState
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