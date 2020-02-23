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

        private bool _diceThrown = false;
        private bool _waitingForPlayerInput = false;
        private bool _playerInputDone = false;

        public IGameState update()
        {
            Debug.Log("[PLAY-RollDiceState] inside");

            if (!_diceThrown)
            {
                _diceThrown = true;
                diceManager.rollTheDice(activePlayer);
            }
            else
            {
                // if (diceManager.diceThrowFinished())
                if (true)
                {
                    //if player has 3 hits or does not want to play
                    if (ruleBook.isPlayerDead(playerManager.getCurrentPlayer()))
                    {
                        resetDiceStates();
                        return endTurnState;
                    }


                    if (!_waitingForPlayerInput)
                    {
                        _waitingForPlayerInput = true;
                        saveScore();
                        menuManager.ActivateDicingMenu();
                        Debug.Log(playerManager.getCurrentPlayer().name + " has now " +
                                  playerManager.getCurrentPlayer().getBrainScore() + " brains");
                    }
                    else
                    {
                        if (menuManager.throwDice)
                        {
                            //resetting states leads to new throw
                            resetDiceStates();
                        }
                        
                        if (menuManager.skipThrow)
                        {
                            resetDiceStates();
                            return endTurnState;
                        }    
                    }
                }
            }
            return this;
        }

        private void resetDiceStates()
        {
            _diceThrown = false;
            _waitingForPlayerInput = false;
            _playerInputDone = false;
        }

        public void setEndTurnState(EndTurnState gameState)
        {
            this.endTurnState = gameState;
        }
        
        private void saveScore()
        {
            playerManager.getCurrentPlayer().addBrainScore(diceManager.getScore());
        }
    }
}