using Base.State;
using UnityEngine;

namespace Modules.DicingZombies.State
{
    public class EndTurnState : GenericGameState, IGameState
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