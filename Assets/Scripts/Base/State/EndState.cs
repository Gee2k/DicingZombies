using UnityEngine;

namespace Base.State
{
    public class EndState : IGameState
    {
        private SetupState _setupState;

        public IGameState update()
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
