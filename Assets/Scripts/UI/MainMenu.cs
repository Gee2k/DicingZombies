using Base;
using Modules.DicingZombies;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private GameManager _gameManager;
    private int _playerAmount = 1;
    private GameObject _mainMenuUI;
    
    //does not belong here but unity does not find inactive objects
    private GameObject _dicingMenu;

    private void Start()
    {
        _gameManager = (GameManager)GameObject.Find("GameManager").GetComponent(typeof(GameManager));
        _mainMenuUI = GameObject.Find("MainMenu");
        
        //decactivate all other menus//
        
        //messi solution will fix later
        _dicingMenu = GameObject.Find("DiceMenu");
        _dicingMenu.SetActive(false);
    }

    public void SetPlayer(int index)
    {
        this._playerAmount = index + 1;
        Debug.Log("Player set to " + _playerAmount);
    }

    public void PlayGame()
    {
        DicingZombiesRuleBook ruleBook = new DicingZombiesRuleBook();
        ruleBook.holder.Add("DiceMenu", _dicingMenu);
        
        _gameManager.SetupGame(ruleBook);
        _mainMenuUI.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
