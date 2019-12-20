using Game.State;

namespace Play.State
{
    public class EndTurnState : GameState
    {
        private SwitchPlayerState switchPlayerState;

        public override GameState update()
        {
            return switchPlayerState;
        }

        public void setSwitchPlayerState(SwitchPlayerState gameState)
        {
            this.switchPlayerState = gameState;
        }
    }
}