using Base.State;
using Modules.DicingZombies.Manager;
using UnityEngine;

namespace Modules.DicingZombies.State
{
    public class EndTurnState : GenericGameState, IGameState
    {
        private SwitchPlayerState switchPlayerState;

        public EndTurnState(PlayerManager playerManager) : base(playerManager)
        {
        }

        public IGameState update()
        {
            Debug.Log("[EndTurnState] inside");
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
            return _playerManager.getCurrentPlayer().isWinner();
        }
    }
}