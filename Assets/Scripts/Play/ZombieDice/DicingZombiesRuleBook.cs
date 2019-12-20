using Game;
using Game.State;
using Play.State;
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
            ruleBookTitle = "DicingZombies";
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

        public override GameState GetInitialPlayState()
        {
            EndTurnState endTurnState = new EndTurnState();
            SwitchPlayerState switchPlayerState = new SwitchPlayerState();
            RollDiceState rollDiceState = new RollDiceState();

            endTurnState.setSwitchPlayerState(switchPlayerState);
            switchPlayerState.setRollDiceState(rollDiceState);
            rollDiceState.setEndTurnState(endTurnState);

            return switchPlayerState;
        }
    }
}