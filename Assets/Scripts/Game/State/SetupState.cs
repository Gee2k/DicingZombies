namespace Game.State
{
    public class SetupState : GameState
    {
        private PlayState playState;

        public override GameState update()
        {
            throw new System.NotImplementedException();
        }

        public void setPlayState(PlayState gamestate)
        {
            this.playState = gamestate;
        }
    }
}