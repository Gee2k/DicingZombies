using Base.State;
using Modules.DicingZombies.Manager;
using UnityEngine;

namespace Modules.DicingZombies.State
{
    public class SwitchPlayerState : GenericGameState, IGameState
    {
        private RollDiceState rollDiceState;

        public IGameState update()
        {
            Debug.Log("[PLAY-SwitchPlayerState] inside");
            playerManager.switchPlayer();
            return rollDiceState;
        }

        public void setRollDiceState(RollDiceState gameState)
        {
            this.rollDiceState = gameState;
        }
    }
}