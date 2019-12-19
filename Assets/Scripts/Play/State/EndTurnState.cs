using Game.State;

namespace Play.State
{
    public class EndTurnState : GameState
    {
        private SwitchPlayerState switchPlayerState;

        public override GameState update()
        {
            throw new System.NotImplementedException();
        }

        public void setSwitchPlayerState(SwitchPlayerState gameState)
        {
            this.switchPlayerState = gameState;
        }
    }
}