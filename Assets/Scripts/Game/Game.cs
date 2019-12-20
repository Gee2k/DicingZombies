using System.Collections.Generic;

namespace Game
{
    public class Game
    {
        public class Builder
        {
            private RuleBook _ruleBook;
            private List<Player> _players;

            public Builder usingGameRules(RuleBook ruleBook)
            {
                this._ruleBook = ruleBook;
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
                
                return new Game(_ruleBook, ruleBookPlayers);
            }
        }

        private RuleBook _ruleBook;
        private List<Player> _players;

        private Game(RuleBook ruleBook, List<Player> players)
        {
            this._ruleBook = ruleBook;
            this._players = players;
        }
    }
}