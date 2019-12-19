using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDiceRules : MonoBehaviour
{
    private List<DiceBehaviour> unusedDice;
    private List<DiceBehaviour> presetDice;

    private const int HardDiceAmount = 3;
    private const int MediumDiceAmount = 4;
    private const int EasyDiceAmount = 6;

    private const int DiceAmountPerRoll = 3;

    void Start()
    {
        InitTurn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InitTurn()
    {
        for (int i = 0; i < HardDiceAmount; i++)
        {
            unusedDice.Add(new HardDice());
        }
        for (int i = 0; i < MediumDiceAmount; i++)
        {
            unusedDice.Add(new MediumDice());
        }
        for (int i = 0; i < EasyDiceAmount; i++)
        {
            unusedDice.Add(new EasyDice());
        }

    }

    public List<DiceBehaviour> GetDiceToRoll()
    {
        int newDiceAmount = DiceAmountPerRoll - presetDice.Count;
        if(newDiceAmount <= unusedDice.Count)
        {
            newDiceAmount = unusedDice.Count; //TODO: use brain dice from score area if no unused dice are left
        } 

        for (int i = 0; i < newDiceAmount; i++)
        {
            int randomIndex = Random.Range(0, unusedDice.Count);
            presetDice.Add(unusedDice[randomIndex]);
            unusedDice.RemoveAt(randomIndex);
        }
        return presetDice;
    }

    public void CalculateScore()
    {

    }
}
