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
        private String _ruleBookTitle;
        private MenuManager _menuManager;
        public abstract Player getRuleBookPlayer(Player player);
        public abstract List<BaseMenu> GetGameMenus();

        /**
         * creates all game specific entities and returns the initial state to start the gameloop
         */
        public abstract IGameState SetupGame();

        public string ruleBookTitle
        {
            get => _ruleBookTitle;
            set => _ruleBookTitle = value;
        }

        public MenuManager menuManager
        {
            get => _menuManager;
            set => _menuManager = value;
        }
    }
}