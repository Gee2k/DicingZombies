using Modules.DicingZombies.Manager;

namespace Modules.DicingZombies.State
{
     public class GenericGameState
    {
        private PlayerManager _playerManager;
        private DiceManager _diceManager;

        public PlayerManager playerManager
        {
            get => _playerManager;
            set => _playerManager = value;
        }

        public DiceManager diceManager
        {
            get => _diceManager;
            set => _diceManager = value;
        }
    }
}