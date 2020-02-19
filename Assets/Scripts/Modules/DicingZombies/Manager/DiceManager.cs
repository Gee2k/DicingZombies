using Base.Assets.Dice;
using Modules.DicingZombies.Assets.Dice;
using System.Collections.Generic;
using Modules.DicingZombies.Assets.Players;
using Random = UnityEngine.Random;

namespace Modules.DicingZombies.Manager
{

    public class DiceManager
    {
        
        //test stuff
        private int totalDice = 3;
        //end teststuff

        private int _brainsScore;
        private List<ZombieDice> _dicePool = new List<ZombieDice>();
        private List<ZombieDice> _rollingDiceList = new List<ZombieDice>();
        private ZombiePlayer _player;

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
        public bool RollTheDice(ZombiePlayer player)
        {
            if (diceRollFinished)
            {
                if (diceRollStarted == false)
                {
                    diceRollFinished = false;
                    diceRollStarted = true;

                    CreateNewDiceList();
                    //throw dices!
                    
                }
                else
                {
                    //dices where thrown, dices fallen?
                    //check the dices beeing idle
                    foreach (var throwenDice in _rollingDiceList)
                    {
                        
                    }
                }

            }

            
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
            return _dicePool[Random.Range(0, _dicePool.Count - 1)];
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
    }
}
