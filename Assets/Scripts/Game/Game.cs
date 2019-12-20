using System.Collections.Generic;
using Game.State;

namespace Game
{
    public class Game
    {
        public class Builder
        {
            private RuleBook _ruleBook;
            private List<Player> _players;
            private GameState _state;

            public Builder usingGameRules(RuleBook ruleBook)
            {
                _ruleBook = ruleBook;
                return this;
            }

            public Builder withPlayers(List<Player> players)
            {
                this._players = players;
                return this;
            }

            public Game build()
            {
                //upgrade Players to RuleBook players
                List<Player> ruleBookPlayers = new List<Player>();
                
                foreach (var player in _players)
                {
                    ruleBookPlayers.Add(_ruleBook.getRuleBookPlayer(player));
                }
                
                return new Game(_ruleBook, ruleBookPlayers, _ruleBook.GetInitialPlayState());
            }
        }

        private RuleBook _ruleBook;
        private List<Player> _players;
        private GameState _state;

        private Game(RuleBook ruleBook, List<Player> players, GameState initialPlayLoopState)
        {
            _ruleBook = ruleBook;
            _players = players;
            _state = initialPlayLoopState;
        }
        
        public Game checkGameState()
        {
            if (_state != null)
            {
                _state = _state.update();
                return this;
            }
            return null;
        }
    }
}