namespace Game
{
    public class InitialState : GameState
    {
        private GameState playState;

        public override GameState update()
        {
            throw new System.NotImplementedException();
        }

        public void setPlayState(GameState gamestate)
        {
            this.playState = gamestate;
        }
    }
}