namespace Game.State
{
    public class EndState : GameState
    {
        private GameState initialState;

        public override GameState update()
        {
            throw new System.NotImplementedException();
        }

        public void setInitialGameState(GameState gameState)
        {
            this.initialState = gameState;
        }
    }
}
