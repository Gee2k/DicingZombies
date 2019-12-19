namespace Game.State
{
   public class PlayState : GameState
    {
        private EndState endState;

        public override GameState update()
        {
            throw new System.NotImplementedException();
        }

        public void setEndState(EndState gameState)
        {
            this.endState = gameState;
        }
    }
}