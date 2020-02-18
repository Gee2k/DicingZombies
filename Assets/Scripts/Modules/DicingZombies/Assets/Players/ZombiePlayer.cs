using Base.Assets;

namespace Modules.DicingZombies.Assets.Players
{
    public class ZombiePlayer : Player
    {
        public bool hasFinishedRound = false;
        private int brainScoreAmount = 0;

        public ZombiePlayer(string name) : base(name)
        {

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