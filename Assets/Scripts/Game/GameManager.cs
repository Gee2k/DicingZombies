using System;
using UnityEngine;
using Game.State;

public class GameManager : MonoBehaviour
{
    private GameState _gameState;

    // Update is called once per frame
    void Update()
    {
        Console.WriteLine("[GameManager] inside");
        _gameState = _gameState?.update();
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
