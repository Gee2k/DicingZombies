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

        private List<ZombieDice> _diceBrains;
        private List<ZombieDice> _diceSteps;
        private List<ZombieDice> _diceShotguns;

        public ZombiePlayer(string name) : base(name)
        {

        }

        public List<ZombieDice> diceBrains
        {
            get => _diceBrains;
            set => _diceBrains = value;
        }
        
        public List<ZombieDice> diceSteps
        {
            get => _diceSteps;
            set => _diceSteps = value;
        }

        public List<ZombieDice> diceShotguns
        {
            get => _diceShotguns;
            set => _diceShotguns = value;
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