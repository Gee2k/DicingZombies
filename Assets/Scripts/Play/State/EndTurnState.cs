using Game.State;
using UnityEngine;

namespace Play.State
{
    public class EndTurnState : GameState
    {
        private SwitchPlayerState switchPlayerState;

        public override GameState update()
        {
            Debug.Log("[EndTurnState] inside");
            return switchPlayerState;
        }

        public void setSwitchPlayerState(SwitchPlayerState gameState)
        {
            this.switchPlayerState = gameState;
        }
    }
}