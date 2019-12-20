using System.Collections.Generic;

namespace Game.State
{
    public class SetupState : GameState
    {
        private PlayState playState;
        private List<Player> players;

        public SetupState()
        {
            Player player = new Player("George");
            players.Add(player);
        }

        public override GameState update()
        {
            return playState;
        }

        public void setPlayState(PlayState gamestate)
        {
            this.playState = gamestate;
        }
    }
}