using System;
using Base;
using Base.State;
using Base.Assets;

namespace Base
{
    public abstract class RuleBook
    {
        private String _ruleBookTitle;
        public abstract Player getRuleBookPlayer(Player player);
        public abstract IGameState SetupStateMachine();

        public string ruleBookTitle
        {
            get => _ruleBookTitle;
            set => _ruleBookTitle = value;
        }
    }
}