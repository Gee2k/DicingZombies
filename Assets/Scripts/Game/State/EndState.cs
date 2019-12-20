using UnityEngine;

namespace Game.State
{
    public class EndState : GameState
    {
        private SetupState _setupState;

        public override GameState update()
        {
            Debug.Log("[EndState] inside");
            //game end

            return null;
        }

        public void setSetupState(SetupState setupState)
        {
            _setupState = setupState;
        }
    }
}
