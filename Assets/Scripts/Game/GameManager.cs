using System;
using UnityEngine;
using Game.State;

public class GameManager : MonoBehaviour
{
    private GameState _gameState;

    // Start is called before the first frame update
    void Start()
    {
        SetupGameStates();
    }

    // Update is called once per frame
    void Update()
    {
        Console.WriteLine("[GameManager] inside");
        if (_gameState == null)
        {
            Console.WriteLine("[GameManager] create new Game");
            SetupGameStates();
        }
        _gameState = _gameState.update();
    }

    private void SetupGameStates()
    {
        SetupState setupState = new SetupState();
        PlayState playState = new PlayState();
        EndState endState = new EndState();

        setupState.SetPlayState(playState);
        playState.SetEndState(endState);
        endState.setSetupState(setupState);

        _gameState = setupState;
    }
}
