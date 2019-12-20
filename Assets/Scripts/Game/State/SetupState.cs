using System.Collections.Generic;
using Play.ZombieDice;

namespace Game.State
{
    public class SetupState : GameState
    {
        private PlayState _playState;
        private List<Player> _players = new List<Player>();
        private Game _game;

        public SetupState()
        {
            Player player = new Player("George");
            _players.Add(player);
            
            //for test purpose create Game here
            RuleBook dicingZombiesRuleBook = new DicingZombiesRuleBook();
            _game = new Game.Builder().withPlayers(_players).usingGameRules(dicingZombiesRuleBook).build();
        }

        public override GameState update()
        {
            //create game Logic here
            
            
            
            // check for game to be setup -> switch state
            if (_game != null)
            {
                _playState.game = _game;
                return _playState;
            }
            return this;
    }

        public void SetPlayState(PlayState gamestate)
        {
            this._playState = gamestate;
        }
    }
}