namespace Game.State
{
    public class EndState : GameState
    {
        private SetupState setupState;

        public override GameState update()
        {
            throw new System.NotImplementedException();
        }

        public void setSetupState(SetupState gameState)
        {
            this.setupState = gameState;
        }
    }
}
