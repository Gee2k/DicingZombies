using Base.State;
using Modules.DicingZombies.Manager;
using UnityEngine;

namespace Modules.DicingZombies.State
{
    public class EndTurnState : GenericGameState, IGameState
    {
        private SwitchPlayerState switchPlayerState;
        
        public IGameState update()
        {
            Debug.Log("[PLAY-EndTurnState] inside");
            if(isGameOver())
            {
                return null;
            }
            return switchPlayerState;
        }

        public void setSwitchPlayerState(SwitchPlayerState gameState)
        {
            this.switchPlayerState = gameState;
        }

        private bool isGameOver()
        {
            return playerManager.getCurrentPlayer().isWinner();
        }
    }
}