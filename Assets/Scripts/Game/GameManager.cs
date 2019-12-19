using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.State;

public class GameManager : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        setupGameStates();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void setupGameStates()
    {
        SetupState setupState = new SetupState();
        PlayState playState = new PlayState();
        EndState endState = new EndState();

        setupState.setPlayState(playState);
        playState.setEndState(endState);
        endState.setSetupState(setupState);

        GameState currentState = setupState;
        while(currentState != null)
        {
            currentState.update();
        }
    }
}
