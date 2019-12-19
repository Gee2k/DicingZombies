using Game;

namespace Play
{
    public class EndTurnState : GameState
    {
        private GameState switchPlayerState;

        public override GameState update()
        {
            throw new System.NotImplementedException();
        }

        public void setSwitchPlayerState(GameState gameState)
        {
            this.switchPlayerState = gameState;
        }
    }
}