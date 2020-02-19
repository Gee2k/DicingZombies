using Base;
using System.Collections.Generic;
using Base.Assets;
using Modules.DicingZombies.Assets.Dice;

namespace Modules.DicingZombies.Assets.Players
{
    public class ZombiePlayer : Player
    {
        public bool isWinner = false;
        public bool hasFinishedRound = false;
        private int brainScoreAmount = 0;
        public List<ZombieDice> dicePool; // TODO: proper handling through methods instead of public accessibility
        public List<ZombieDice> diceResult; // TODO: proper handling through methods instead of public accessibility

        public ZombiePlayer(string name) : base(name)
        {

        }

        public void setDicePool(List<ZombieDice> dicePool)
        {
            this.dicePool = dicePool;
        }

        public void addBrainScore(int amount)
        {
            this.brainScoreAmount += amount;
        }

        public int getBrainScore()
        {
            return this.brainScoreAmount;
        }
    }
}