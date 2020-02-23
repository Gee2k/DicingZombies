using Base.Assets.Dice;
using Modules.DicingZombies.Assets.Dice;
using System;
using System.Collections.Generic;
using Base;
using Modules.DicingZombies.Assets.Players;
// using Random = UnityEngine.Random;

namespace Modules.DicingZombies.Manager
{

    public class DiceManager
    {
        private const int MAX_HIT_COUNT = 3;
        private const int DICE_ROLL_AMOUNT = 3;
        
        //test stuff
        private int totalDice = 3;
        //end teststuff

        private int _brainsScore;
        private List<ZombieDice> _dicePool = new List<ZombieDice>();
        private List<ZombieDice> _rollingDiceList = new List<ZombieDice>();
        private List<ZombieDice> diceResult = new List<ZombieDice>();
        private ZombiePlayer _player;
        
        private DiceEmitter<ZombieDice> _emitter;

        private bool diceRollFinished = false;
        private bool diceRollStarted = false;
        
        /**
         * rolling 3 random dice
         *
         * checks that there are available dice
         * if not restocking is done
         * then the dice are thrown
         * scoring is examined
         */
        public void rollTheDice(ZombiePlayer player)
        {
            // if (diceRollFinished)
            // {
            //     if (diceRollStarted == false)
            //     {
            //         diceRollFinished = false;
            //         diceRollStarted = true;
            //
            //         CreateNewDiceList();
            //         //throw dices!
            //         
            //     }
            //     else
            //     {
            //         //dices where thrown, dices fallen?
            //         //check the dices beeing idle
            //         foreach (var throwenDice in _rollingDiceList)
            //         {
            //             
            //         }
            //     }
            //
            // }
        }

        /**
         * creates a new set of dice to throw
         */
        private void CreateNewDiceList()
        {
            
            for (; _rollingDiceList.Count < totalDice;)
            {
                _rollingDiceList.Add(GetRandomDice());
            }
        }


        /**
         * returns a new random dice from the stock if there are.
         * if not a restocking is initiated by taking the player brains
         */
        private ZombieDice GetRandomDice()
        {
            if (_dicePool.Count == 0)
            {
                //restock player brains
                RestockBrains();
            }
            Random rnd = new Random(); //demo

            return _dicePool[rnd.Next(0, _dicePool.Count - 1)];
            // return _dicePool[Random.Range(0, _dicePool.Count - 1)];
        }

        /**
         * save player brain score
         * remove brains from player list and restock
         */
        private void RestockBrains()
        {
            _brainsScore += _player.diceBrains.Count;
            _dicePool.AddRange(_player.diceBrains);
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
            // hitCount =  Random.Range(0, 4);
            return hitCount;
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
            // brainScore = Random.Range(1, 3);
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
                    _dicePool.Add(dice);
                }
            }
            diceResult.RemoveAll(dice => ZombieDiceValueEnum.Escape.Equals(dice.GetDiceValue()));
        }

        private void restockFromBrains()
        {
            if (_dicePool.Count <= DICE_ROLL_AMOUNT)
            {
                foreach (ZombieDice dice in diceResult)
                {
                    if (ZombieDiceValueEnum.Brain.Equals(dice.GetDiceValue()))
                    {
                        _dicePool.Add(dice);
                    }
                }
            }
        }
    }
}
