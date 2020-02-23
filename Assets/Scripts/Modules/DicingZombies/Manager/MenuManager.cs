using Base;
using Modules.DicingZombies.Assets.Players;
using UnityEngine;

namespace Modules.DicingZombies.Manager
{
    public class MenuManager
    {
        private GameObject _diceMenu;
        private GameObject _skipButton;
        private GameObject _throwButton;
        
        private bool _throwDice = false;
        private bool _skipThrow = false;
        
        public GameObject diceMenu
        {
            get => _diceMenu;
            set => _diceMenu = value;
        }

        public bool throwDice
        {
            get => _throwDice;
            set => _throwDice = value;
            // get => _diceMenu.GetComponent<DicingMenu>().throwDice;
        }

        public bool skipThrow
        {
            get => _skipThrow;
            set => _skipThrow = value;
            // get => _diceMenu.GetComponent<DicingMenu>().skipThrow;
        }

        public void ActivateDicingMenu()
        {
            _diceMenu.SetActive(true);
        }
    }
}