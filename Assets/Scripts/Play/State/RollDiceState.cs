using Game.State;
using Play.ZombieDice;
using System.Collections.Generic;
using UnityEngine;

namespace Play.State
{
    public class RollDiceState : GenericGameState
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
            return endTurnState;
        }

        public void setEndTurnState(EndTurnState gameState)
        {
            this.endTurnState = gameState;
        }

        public void setActivePlayer(ZombiePlayer player)
        {
            this.activePlayer = player;
            player.diceResult = new List<ZombieDice.ZombieDice>();
        }

        public bool isPlayerDead()
        {
            int hitCount = 0;
            foreach(ZombieDice.ZombieDice dice in activePlayer.diceResult)
            {
                if(ZombieDiceValueEnum.Hit.Equals(dice.GetDiceValue()))
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
            restockFromEscapes();
            restockFromBrains();
        }

        private void restockFromEscapes()
        {
            foreach (ZombieDice.ZombieDice dice in activePlayer.diceResult)
            {
                if (ZombieDiceValueEnum.Escape.Equals(dice.GetDiceValue()))
                {
                    activePlayer.dicePool.Add(dice);
                }
            }
            activePlayer.diceResult.RemoveAll(dice => ZombieDiceValueEnum.Escape.Equals(dice.GetDiceValue()));
        }

        private void restockFromBrains()
        {
            if (activePlayer.dicePool.Count <= DICE_ROLL_AMOUNT)
            {
                foreach (ZombieDice.ZombieDice dice in activePlayer.diceResult)
                {
                    if (ZombieDiceValueEnum.Brain.Equals(dice.GetDiceValue()))
                    {
                        activePlayer.dicePool.Add(dice);
                    }

                }
            }
        }
    }
}