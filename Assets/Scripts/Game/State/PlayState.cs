namespace Game.State
{
   public class PlayState : GameState
    {
        private GameState endState;

        public override GameState update()
        {
            throw new System.NotImplementedException();
        }

        public void setEndState(GameState gameState)
        {
            this.endState = gameState;
        }
    }
}