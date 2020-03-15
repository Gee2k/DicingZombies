using System;
using System.Collections.Generic;
using Base.Assets;
using UnityEngine;
using Base.State;
using Modules.DicingZombies;

namespace Base
{
    public class GameManager : MonoBehaviour
    {
        private IGameState _gameState;
        private MenuManager _menuManager;
       
        private void Start()
        {
            _menuManager = new MenuManager();
            //initialize menus
            BaseMenu mainMenu = new BaseMenu("MainMenu");
            _menuManager.AddMenu(mainMenu);
        }

        // Update is called once per frame
        void Update()
        {
            Console.WriteLine("[GameManager] inside");
            if (_gameState != null)
            {
                _gameState = _gameState?.update();
            }
            else if (_gameState == null)
            {
                _menuManager.showMenu("MainMenu");
                Debug.Log("[GameManager] reenabled Menu");
            }
        }

        public void SetupGame(RuleBook ruleBook)
        {
            if (_gameState == null)
            {
                Console.WriteLine("[GameManager] create new Game of type " + ruleBook.ruleBookTitle);

                SetupState setupState = new SetupState(ruleBook, _menuManager);    //todo pass RuleBook to setup which is chosen in the menu by the player
                PlayState playState = new PlayState();
                EndState endState = new EndState();

                setupState.SetPlayState(playState);
                playState.SetEndState(endState);
                endState.setSetupState(setupState);

                _gameState = setupState;
            }
        }

        public MenuManager menuManager
        {
            get => _menuManager;
        }
    }
}