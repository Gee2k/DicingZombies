namespace Game.State
{
    public class EndState : GameState
    {
        private GameState setupState;

        public override GameState update()
        {
            throw new System.NotImplementedException();
        }

        public void setSetupState(GameState gameState)
        {
            this.setupState = gameState;
        }
    }
}
