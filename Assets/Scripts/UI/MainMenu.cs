using System;
using System.Collections;
using System.Collections.Generic;
using Play.ZombieDice;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private GameManager _gameManager;
    private int _playerAmount = 1;
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
        _gameManager.SetupGame(new DicingZombiesRuleBook());
    }

    public void QuitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
