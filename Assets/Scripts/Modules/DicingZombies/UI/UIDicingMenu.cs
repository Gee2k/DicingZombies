using System;
using Modules.DicingZombies.Manager;
using Modules.DicingZombies.State;
using UnityEngine;

public class UIDicingMenu : MonoBehaviour
{
    private GameObject _diceMenuUI;
    private bool _throwDice = false;
    private bool _skipThrow = false;
        
    public bool throwDice
    {
        get
        {
            bool returnvalue = _throwDice;
            _throwDice = !_throwDice;
            return returnvalue;
        }
        set => _throwDice = value;
    }

    public bool skipThrow
    {
        get
        {
            bool returnvalue = _skipThrow;
            _skipThrow = !_skipThrow;
            return returnvalue;
        }
        set => _skipThrow = value;
    }

    private void Start()
    {
        _diceMenuUI = GameObject.Find("DiceMenu");
    }
    
    public void ThrowDice()
    {
        // _throwDice = true;
        throwDice = true;
        _diceMenuUI.SetActive(false);
        Debug.Log("throwing...");
    }

    public void SkipThrow()
    {
        skipThrow = true;
        _diceMenuUI.SetActive(false);
        Debug.Log("skipping...");
    }
}
