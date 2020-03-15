using Base;
using Modules.DicingZombies;
using UnityEngine;

public class UIMainMenu : MonoBehaviour
{
    private GameManager _gameManager;
    private int _playerAmount = 1;
    
    //does not belong here but unity does not find inactive objects
    private GameObject _dicingMenu;

    private void Start()
    {
        _gameManager = (GameManager)GameObject.Find("GameManager").GetComponent(typeof(GameManager));
    }

    public void SetPlayer(int index)
    {
        this._playerAmount = index + 1;
        Debug.Log("Player set to " + _playerAmount);
    }

    public void PlayGame()
    {
        DicingZombiesRuleBook ruleBook = new DicingZombiesRuleBook();
        _gameManager.SetupGame(ruleBook);
        
        // _mainMenuUI.SetActive(false);
        _gameManager.menuManager.hideMenu("MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
