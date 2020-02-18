using Base.State;
using Modules.DicingZombies.Manager;
using UnityEngine;

namespace Modules.DicingZombies.State
{
    public class SwitchPlayerState : GenericGameState, IGameState
    {
        private RollDiceState rollDiceState;

        public SwitchPlayerState(PlayerManager playerManager) : base(playerManager)
        {
        }

        public IGameState update()
        {
            Debug.Log("[SwitchPlayerState] inside");
            _playerManager.switchPlayer();
            return rollDiceState;
        }

        public void setRollDiceState(RollDiceState gameState)
        {
            this.rollDiceState = gameState;
        }
    }
}