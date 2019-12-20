using Game.State;
using Play.ZombieDice;
using System.Collections.Generic;
using UnityEngine;

namespace Play.State
{
    public class RollDiceState : GameState
    {
        private EndTurnState endTurnState;
        private ZombiePlayer activePlayer;
        private const int MAX_HIT_COUNT = 3;
        private const int DICE_ROLL_AMOUNT = 3;

        public RollDiceState()
        {

        }

        public override GameState update()
        {
            Debug.Log("[RollDiceState] inside");
            return endTurnState;
        }

        public void setEndTurnState(EndTurnState gameState)
        {
            this.endTurnState = gameState;
        }

        public void setActivePlayer(ZombiePlayer player)
        {
            this.activePlayer = player;
            player.diceResult = new List<ZombieDiceSideValue>();
        }

        public bool isPlayerDead()
        {
            int hitCount = 0;
            foreach(ZombieDiceSideValue diceValue in activePlayer.diceResult)
            {
                if(ZombieDiceValueEnum.Hit.Equals(diceValue.getValue()))
                {
                    hitCount++;
                }
            }
            return hitCount > MAX_HIT_COUNT;
        }

        public List<ZombieDice.ZombieDice> getDiceToRoll()
        {
            restockPool();

            /*
            int newDiceAmount = DiceAmountPerRoll - presetDice.Count;
            if (newDiceAmount <= unusedDice.Count)
            {
                newDiceAmount = unusedDice.Count; //TODO: use brain dice from score area if no unused dice are left
            }

            for (int i = 0; i < newDiceAmount; i++)
            {
                int randomIndex = Random.Range(0, unusedDice.Count);
                presetDice.Add(unusedDice[randomIndex]);
                unusedDice.RemoveAt(randomIndex);
            }
            return presetDice;
            */
            throw new System.NotImplementedException();
        }

        private void restockPool()
        {
            restockFromSteps();
            restockFromBrains();
        }

        private void restockFromSteps()
        {
            foreach (ZombieDiceSideValue diceValue in activePlayer.diceResult)
            {
                if (ZombieDiceValueEnum.Steps.Equals(diceValue.getValue()))
                {
                    //activePlayer.dicePool.Add(); TODO: restock dicePool from steps
                }
            }
        }

        private void restockFromBrains()
        {
            if(activePlayer.dicePool.Count <= DICE_ROLL_AMOUNT)
            {
                //restock from brains? or random? read rules
            }
        }
    }
}