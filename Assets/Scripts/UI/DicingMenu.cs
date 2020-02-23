using System;
using Modules.DicingZombies.Manager;
using UnityEngine;

public class DicingMenu : MonoBehaviour
{
    private GameObject _diceMenuUI;
    private MenuManager _menuManager;

    private void Start()
    {
        _diceMenuUI = GameObject.Find("DiceMenu");
    }
    
    public void ThrowDice()
    {
        // _throwDice = true;
        _menuManager.throwDice = true;
        _diceMenuUI.SetActive(false);
    }

    public void SkipThrow()
    {
        _menuManager.skipThrow = true;
        _diceMenuUI.SetActive(false);
    }
}
