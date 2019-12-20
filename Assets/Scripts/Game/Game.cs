using System.Collections.Generic;

namespace Game
{
    public class Game
    {
        public class Builder
        {
            private RuleBook ruleBook;
            private List<Player> players;

            public Builder usingGameRules(RuleBook ruleBook)
            {
                this.ruleBook = ruleBook;
                return this;
            }

            public Builder withPlayers(List<Player> players)
            {
                this.players = players;
                return this;
            }

            public Game build()
            {
                return new Game(ruleBook, players);
            }
        }

        private RuleBook ruleBook;
        private List<Player> players;

        private Game(RuleBook ruleBook, List<Player> players)
        {
            this.ruleBook = ruleBook;
            this.players = players;
        }
    }
}