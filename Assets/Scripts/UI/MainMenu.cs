using System;
using System.Collections;
using System.Collections.Generic;
using Play.ZombieDice;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private GameManager _gameManager;
    private void Start()
    {
        _gameManager = (GameManager)GameObject.Find("GameManager").GetComponent(typeof(GameManager));
    }

    public void PlayGame()
    {
        _gameManager.SetupGame(new DicingZombiesRuleBook());
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
