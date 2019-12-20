using Game;
using UnityEngine;

namespace Play.ZombieDice
{
    public class DicingZombiesRuleBook : RuleBook
    {
        public GameObject GreenDice;
        public GameObject YellowDice;
        public GameObject RedDice;

        public DicingZombiesRuleBook()
        {
            //find Models for Dice and attach
            // List<GameObject> gameObjects = (Resources.FindObjectsOfTypeAll(typeof(GameObject))).OfType<GameObject>().ToList();
            
            GreenDice = Resources.Load("greenDiceGameObject") as GameObject;
            YellowDice = Resources.Load("yellowDiceGameObject") as GameObject;
            RedDice = Resources.Load("redDiceGameObject") as GameObject;

            // List<GameObject> gameObjects2 = (Resources.FindObjectsOfTypeAll(typeof(GameObject))).OfType<GameObject>().ToList();
        }

        public override Player getRuleBookPlayer(Player player)
        {
            return new ZombiePlayer(player.name);
        }
    }
}