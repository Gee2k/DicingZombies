using System.Collections.Generic;

namespace Game.State
{
    public class SetupState : GameState
    {
        private PlayState playState;
        private List<Player> players;

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