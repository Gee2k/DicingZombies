using System.Collections.Generic;
using Base.State;
using UnityEngine;
using Base.Assets;

namespace Base
{
    public class Game
    {
        private RuleBook _ruleBook;
        private List<Player> _players;
        private IGameState _state;
        
        private Game(RuleBook ruleBook, List<Player> players, IGameState initialPlayLoopState)
        {
            _ruleBook = ruleBook;
            _players = players;
            _state = initialPlayLoopState;
        }
        
        public class Builder
        {
            private RuleBook _ruleBook;
            private List<Player> _players;
            private IGameState _state;

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

            public Game build(MenuManager menuManager)
            {
                Debug.Log("[Game] new game created of type " + _ruleBook.ruleBookTitle + "");
                //upgrade Players to RuleBook players
                List<Player> ruleBookPlayers = new List<Player>();
                _ruleBook.menuManager = menuManager;
                foreach (var player in _players)
                {
                    ruleBookPlayers.Add(_ruleBook.getRuleBookPlayer(player));
                }
                
                return new Game(_ruleBook, ruleBookPlayers, _ruleBook.SetupGame());
            }
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