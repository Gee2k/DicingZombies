using System;
using System.Collections.Generic;
using Base;
using Base.State;
using Base.Assets;
using UnityEngine;

namespace Base
{
    public abstract class RuleBook
    {
        private Dictionary<String, GameObject> _holder = new Dictionary<string, GameObject>();
        private String _ruleBookTitle;
        public abstract Player getRuleBookPlayer(Player player);
        public abstract IGameState SetupStateMachine();

        public string ruleBookTitle
        {
            get => _ruleBookTitle;
            set => _ruleBookTitle = value;
        }

        public Dictionary<string, GameObject> holder
        {
            get => _holder;
            set => _holder = value;
        }
    }
}