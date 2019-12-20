using System.Collections.Generic;
using Game;

namespace ZombieDare
{
    public class Game
    {
        private class Builder
        {
            private Game game;
            private RuleBook ruleBook;
            private List<Player> players;
            
            public Builder withRules(RuleBook ruleBook)
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
                game = new Game(ruleBook, players);
                return game;
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