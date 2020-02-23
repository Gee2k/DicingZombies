﻿using System.Collections.Generic;
using UnityEngine;
using Modules.DicingZombies;
using Base.Assets;
using Modules.DicingZombies.Assets.Players;

namespace Base.State
{
    public class SetupState : IGameState
    {
        private PlayState _playState;
        private List<Player> _players = new List<Player>();
        private Game _game;

        public SetupState()
        {
            //for test purpose create Game here
            RuleBook dicingZombiesRuleBook = new DicingZombiesRuleBook();
            _game = new Game.Builder().withPlayers(_players).usingGameRules(dicingZombiesRuleBook).build();
        }

        public IGameState update()
        {
            Debug.Log("[SetupState] inside");
            //create game Logic here



            // check for game to be setup -> switch state
            if (_game != null)
            {
                _playState.game = _game;
                return _playState;
            }
            return this;   
        }

        public void SetPlayState(PlayState playState)
        {
            _playState = playState;
        }
    }
}