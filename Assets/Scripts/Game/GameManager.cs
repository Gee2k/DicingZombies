using UnityEngine;
using Game.State;

public class GameManager : MonoBehaviour
{
    private GameState currentState;

    // Start is called before the first frame update
    void Start()
    {
        setupGameStates();
    }

    // Update is called once per frame
    void Update()
    {
        this.currentState = currentState.update();
    }

    private void setupGameStates()
    {
        SetupState setupState = new SetupState();
        PlayState playState = new PlayState();
        EndState endState = new EndState();

        setupState.setPlayState(playState);
        playState.setEndState(endState);
        endState.setSetupState(setupState);

        this.currentState = setupState;
    }
}
