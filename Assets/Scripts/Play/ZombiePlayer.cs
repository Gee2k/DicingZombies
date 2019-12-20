using Game;
using Play.ZombieDice;
using System.Collections.Generic;

namespace Play
{
    public class ZombiePlayer : Player
    {
        public bool isWinner = false;
        public bool hasFinishedRound = false;
        private int brainScoreAmount = 0;
        public List<ZombieDice.ZombieDice> dicePool; // TODO: proper handling through methods instead of public accessibility
        public List<ZombieDiceSideValue> diceResult; // TODO: proper handling through methods instead of public accessibility

        public ZombiePlayer(string name) : base(name)
        {

        }

        public void setDicePool(List<ZombieDice.ZombieDice> dicePool)
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