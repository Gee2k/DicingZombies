using UnityEngine;
using Game.State;

public class GameManager : MonoBehaviour
{
    private GameState _currentState;

    // Start is called before the first frame update
    void Start()
    {
        SetupGameStates();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentState = _currentState.update();
    }

    private void SetupGameStates()
    {
        SetupState setupState = new SetupState();
        PlayState playState = new PlayState();
        EndState endState = new EndState();

        setupState.SetPlayState(playState);
        playState.setEndState(endState);
        endState.setSetupState(setupState);

        this._currentState = setupState;
    }
}
