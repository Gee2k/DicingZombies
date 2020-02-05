using Game.State;
using UnityEngine;

namespace Play.State
{
    public class EndTurnState : GenericGameState
    {
        private SwitchPlayerState switchPlayerState;

        public IGameState update()
        {
            Debug.Log("[EndTurnState] inside");
            // return switchPlayerState;
            return null;    //testing end of game
        }

        public void setSwitchPlayerState(SwitchPlayerState gameState)
        {
            this.switchPlayerState = gameState;
        }
    }
}