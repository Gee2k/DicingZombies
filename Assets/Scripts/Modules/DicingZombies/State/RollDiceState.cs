using Base.State;
using Modules.DicingZombies.Assets.Players;
using Modules.DicingZombies.Assets.Dice;
using System.Collections.Generic;
using UnityEngine;
using Modules.DicingZombies.Manager;

namespace Modules.DicingZombies.State
{
    public class RollDiceState : GenericGameState, IGameState
    {
        private EndTurnState endTurnState;
        private ZombiePlayer activePlayer;
        private const int MAX_HIT_COUNT = 3;
        private const int DICE_ROLL_AMOUNT = 3;

        public RollDiceState()
        {

        }

        public IGameState update()
        {
            Debug.Log("[RollDiceState] inside");
            
            //if player has 3 hits or does not want to play
            //// next()
            //else
            //// rollTheDIce!
            
            //return endTurnState;
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
        
        public bool isPlayerDead()
        {
            return playerManager.activePlayer.diceShotguns.Count >= MAX_HIT_COUNT;
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