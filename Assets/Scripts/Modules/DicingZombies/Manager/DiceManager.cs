using Base.Assets.Dice;
using Modules.DicingZombies.Assets.Dice;
using System;
using System.Collections.Generic;

namespace Modules.DicingZombies.Manager
{

    public class DiceManager
    {
        private const int MAX_HIT_COUNT = 3;
        private const int DICE_ROLL_AMOUNT = 3;

        public List<ZombieDice> dicePool; // TODO: proper handling through methods instead of public accessibility
        public List<ZombieDice> diceResult; // TODO: proper handling through methods instead of public accessibility

        public DiceManager()
        {
            dicePool = new List<ZombieDice>();
            diceResult = new List<ZombieDice>();
        }

        public List<DiceBehaviour<ZombieDice>> throwDice(List<DiceBehaviour<ZombieDice>> dice){
            return null;
        }

        public void setDicePool(List<ZombieDice> dicePool)
        {
            this.dicePool = dicePool;
        }
               
        public bool isTurnLost()
        {
            return countHits() > MAX_HIT_COUNT;
        }

        private int countHits()
        {
            int hitCount = 0;
            foreach (ZombieDice dice in diceResult)
            {
                if (ZombieDiceValueEnum.Hit.Equals(dice.GetDiceValue()))
                {
                    hitCount++;
                }
            }
            Random rnd = new Random(); //demo
            hitCount =  rnd.Next(4); 
            return hitCount;
        }

        public void rollTheDice()
        {
        }

        public int getScore()
        {
            int brainScore = 0;
            foreach (ZombieDice dice in diceResult)
            {
                if (ZombieDiceValueEnum.Brain.Equals(dice.GetDiceValue()))
                {
                    brainScore++;
                }
            }
            Random rnd = new Random(); //demo
            brainScore = rnd.Next(1,3);
            return brainScore;
        }

        public List<ZombieDice> getDiceToRoll()
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
            foreach (ZombieDice dice in diceResult)
            {
                if (ZombieDiceValueEnum.Escape.Equals(dice.GetDiceValue()))
                {
                    dicePool.Add(dice);
                }
            }
            diceResult.RemoveAll(dice => ZombieDiceValueEnum.Escape.Equals(dice.GetDiceValue()));
        }

        private void restockFromBrains()
        {
            if (dicePool.Count <= DICE_ROLL_AMOUNT)
            {
                foreach (ZombieDice dice in diceResult)
                {
                    if (ZombieDiceValueEnum.Brain.Equals(dice.GetDiceValue()))
                    {
                        dicePool.Add(dice);
                    }

                }
            }
        }
    }
}
