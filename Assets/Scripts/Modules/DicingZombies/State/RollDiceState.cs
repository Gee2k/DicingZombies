using Base.State;
using UnityEngine;
using Modules.DicingZombies.Manager;

namespace Modules.DicingZombies.State
{
    public class RollDiceState : GenericGameState, IGameState
    {
        private EndTurnState endTurnState;
        private DiceManager _diceManager;

        public RollDiceState(PlayerManager playerManager) : base(playerManager)
        {
            _diceManager = new DiceManager();
        }

        public IGameState update()
        {
            Debug.Log("[RollDiceState] inside");
            _diceManager.rollTheDice();
            if(_diceManager.isTurnLost())
            {
                Debug.Log(_playerManager.getCurrentPlayer().name + " got shot and lost the turn");
                return endTurnState;
            }
            else
            {
                saveScore();
                Debug.Log(_playerManager.getCurrentPlayer().name + " has now " +_playerManager.getCurrentPlayer().getBrainScore() + " brains");
                if (playerSkipsTurn())
                {
                    return endTurnState;
                }
            }
            Debug.Log(_playerManager.getCurrentPlayer().name + " skips her turn");
            return this;
        }

        public void setEndTurnState(EndTurnState gameState)
        {
            this.endTurnState = gameState;
        }

        private bool playerSkipsTurn()
        {
            System.Random rnd = new System.Random();
            return rnd.Next(2) == 0; // quick boolean random for 50/50 
        }

        private void saveScore()
        {
            _playerManager.getCurrentPlayer().addBrainScore(_diceManager.getScore());
        }
    }
}