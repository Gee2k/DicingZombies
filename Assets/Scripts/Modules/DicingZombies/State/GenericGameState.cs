using Modules.DicingZombies.Manager;

namespace Modules.DicingZombies.State
{
     public class GenericGameState
    {
        private PlayerManager _playerManager;
        private DiceManager _diceManager;
        private MenuManager _menuManager;
        private DicingZombiesRuleBook _ruleBook;

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

        public MenuManager menuManager
        {
            get => _menuManager;
            set => _menuManager = value;
        }

        public DicingZombiesRuleBook ruleBook
        {
            get => _ruleBook;
            set => _ruleBook = value;
        }
    }
}