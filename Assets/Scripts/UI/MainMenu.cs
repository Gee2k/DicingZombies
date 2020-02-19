using Base;
using Modules.DicingZombies;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private GameManager _gameManager;
    private int _playerAmount = 1;
    private GameObject _mainMenuUI;

    private void Start()
    {
        _gameManager = (GameManager)GameObject.Find("GameManager").GetComponent(typeof(GameManager));
        _mainMenuUI = GameObject.Find("MainMenu");
    }

    public void SetPlayer(int index)
    {
        this._playerAmount = index + 1;
        Debug.Log("Player set to " + _playerAmount);
    }

    public void PlayGame()
    {
        _gameManager.SetupGame(new DicingZombiesRuleBook());
        _mainMenuUI.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
