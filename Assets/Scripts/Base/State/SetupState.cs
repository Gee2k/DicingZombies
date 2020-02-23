using System.Collections.Generic;
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

        public SetupState(RuleBook ruleBook)
        {
            //for test purpose create Game here
            // RuleBook dicingZombiesRuleBook = new DicingZombiesRuleBook();
            // _game = new Game.Builder().withPlayers(_players).usingGameRules(dicingZombiesRuleBook).build();
            _game = new Game.Builder().withPlayers(_players).usingGameRules(ruleBook).build();
        }

        public IGameState update()
        {
            Debug.Log("[BASE-SetupState] inside");
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