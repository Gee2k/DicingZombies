using Base;
using System.Collections.Generic;
using Base.Assets;
using Modules.DicingZombies.Assets.Dice;

namespace Modules.DicingZombies.Assets.Players
{
    public class ZombiePlayer : Player
    {
        public bool hasFinishedRound = false;
        private int brainScoreAmount = 0;

        private List<ZombieDice> _diceBrains = new List<ZombieDice>();
        private List<ZombieDice> _diceSteps = new List<ZombieDice>();
        private List<ZombieDice> _diceShotguns = new List<ZombieDice>();

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

        public bool isWinner()
        {
            return brainScoreAmount >= 10;
        }
    }
}