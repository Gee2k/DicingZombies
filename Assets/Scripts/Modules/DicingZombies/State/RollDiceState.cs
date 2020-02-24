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

        public IGameState update()
        {
            Debug.Log("[RollDiceState] inside");

            //// rollTheDIce!
            diceManager.rollTheDice(activePlayer);


            //if player has 3 hits or does not want to play
            if (isPlayerDead())
            {
                return endTurnState;
            }
            
            //play did not lose, so save the points
            saveScore();
            Debug.Log(playerManager.getCurrentPlayer().name + " has now " + playerManager.getCurrentPlayer().getBrainScore() + " brains");
            
            if (playerSkipsTurn())
            {
                return endTurnState;
            }
            return this;
        }

        public void setEndTurnState(EndTurnState gameState)
        {
            this.endTurnState = gameState;
        }
        
        public bool isPlayerDead()
        {
            Debug.Log(playerManager.getCurrentPlayer().name + " got shot and lost the turn");
            // return playerManager.activePlayer.diceShotguns.Count >= MAX_HIT_COUNT;
            return playerManager.getCurrentPlayer().diceShotguns.Count >= MAX_HIT_COUNT;
        }
        
        private bool playerSkipsTurn()
        {
            bool isSkipping = Random.Range(0, 1) == 0;
            // System.Random rnd = new System.Random();
            // return rnd.Next(2) == 0; // quick boolean random for 50/50
            if (isSkipping)
            {
                Debug.Log(playerManager.getCurrentPlayer().name + " skips her turn");
            }

            return isSkipping;
        }

        private void saveScore()
        {
            playerManager.getCurrentPlayer().addBrainScore(diceManager.getScore());
        }
    }
}