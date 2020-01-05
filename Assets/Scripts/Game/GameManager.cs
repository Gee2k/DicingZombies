using System;
using UnityEngine;
using Game.State;

public class GameManager : MonoBehaviour
{
    private GameState _gameState;
    private GameObject _mainMenuUI;
    
    private void Start()
    {
        _mainMenuUI = GameObject.Find("MainMenu");
    }

    // Update is called once per frame
    void Update()
    {
        Console.WriteLine("[GameManager] inside");
        if (_gameState != null)
        {
            _gameState = _gameState?.update();
        }
        else if(_gameState == null && !_mainMenuUI.activeSelf)
        {
            _mainMenuUI.SetActive(true);
            Debug.Log("[GameManager] reenabled Menu");
        }
    }

    public void SetupGame(RuleBook ruleBook)
    {
        if (_gameState == null)
        {
            Console.WriteLine("[GameManager] create new Game of type " + ruleBook.ruleBookTitle);
            
            SetupState setupState = new SetupState();    //todo pass RuleBook to setup which is chosen in the menu by the player
            PlayState playState = new PlayState();
            EndState endState = new EndState();

            setupState.SetPlayState(playState);
            playState.SetEndState(endState);
            endState.setSetupState(setupState);

            _gameState = setupState;
        }
    }
}
