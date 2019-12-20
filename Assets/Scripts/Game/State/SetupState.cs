using System.Collections.Generic;
using Play.ZombieDice;

namespace Game.State
{
    public class SetupState : GameState
    {
        private PlayState playState;
        private List<Player> players;
        private Game _game;

        public SetupState()
        {
            Player player = new Player("George");
            players.Add(player);
            
            //for test purpose create Game here
            RuleBook dicingZombiesRuleBook = new DicingZombiesRuleBook();
            _game = new Game.Builder().withPlayers(players).usingGameRules(dicingZombiesRuleBook).build();
        }

        public override GameState update()
        {
            //create game Logic here
            
            
            
            // check for game to be setup -> switch state
            if (_game != null)
            {
                playState.game = _game;
                return playState;
            }
            return this;
    }

        public void setPlayState(PlayState gamestate)
        {
            this.playState = gamestate;
        }
    }
}