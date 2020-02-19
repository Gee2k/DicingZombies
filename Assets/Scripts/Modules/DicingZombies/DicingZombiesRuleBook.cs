using System.Collections.Generic;
using Base;
using Base.State;
using Base.Assets;
using Modules.DicingZombies.Assets.Dice;
using Modules.DicingZombies.Assets.Players;
using Modules.DicingZombies.Manager;
using Modules.DicingZombies.State;
using UnityEngine;

namespace Modules.DicingZombies
{
    public class DicingZombiesRuleBook : RuleBook
    {
        private int amountGreenDice = 6;
        private int amountYellowDice = 4;
        private int amountRedDice = 3;

        private ZombieDice _greenDice;
        private ZombieDice _yellowDice;
        private ZombieDice _redDice;
        
        readonly List<ZombieDice> _zombieDices = new List<ZombieDice>();
        
        private List<GenericGameState> _gameStates = new List<GenericGameState>();
        public DicingZombiesRuleBook()
        {
            ruleBookTitle = "DicingZombies";
            //find Models for DiceBehaviour and attach
            // List<GameObject> gameObjects = (Resources.FindObjectsOfTypeAll(typeof(GameObject))).OfType<GameObject>().ToList();

            GameObject greenDiceGameObject = Resources.Load("greenDiceGameObject") as GameObject;
            GameObject yellowDiceGameObject = Resources.Load("yellowDiceGameObject") as GameObject;
            GameObject redDiceGameObject = Resources.Load("redDiceGameObject") as GameObject;

            // List<GameObject> gameObjects2 = (Resources.FindObjectsOfTypeAll(typeof(GameObject))).OfType<GameObject>().ToList();

            //create dices
            for (int i = 0; i < amountGreenDice; i++)
            {
                _zombieDices.Add(new ZombieDice(ZombieDiceSideColorEnum.Green, greenDiceGameObject));
            }
            //create dices
            for (int i = 0; i < amountYellowDice; i++)
            {
                _zombieDices.Add(new ZombieDice(ZombieDiceSideColorEnum.Yellow, yellowDiceGameObject));
            }
            //create dices
            for (int i = 0; i < amountRedDice; i++)
            {
                _zombieDices.Add(new ZombieDice(ZombieDiceSideColorEnum.Red, redDiceGameObject));
            }
        }

        public override Player getRuleBookPlayer(Player player)
        {
            return new ZombiePlayer(player.name);
        }

        public override IGameState SetupStateMachine()
        {
            DiceManager diceManager = new DiceManager();
            PlayerManager playerManager = new PlayerManager();
            
            EndTurnState endTurnState = new EndTurnState();
            SwitchPlayerState switchPlayerState = new SwitchPlayerState();
            RollDiceState rollDiceState = new RollDiceState();
            
            _gameStates.Add(endTurnState);
            _gameStates.Add(switchPlayerState);
            _gameStates.Add(rollDiceState);
            foreach (var gameState in _gameStates)
            {
                gameState.diceManager = diceManager;
                gameState.playerManager = playerManager;
            }

            endTurnState.setSwitchPlayerState(switchPlayerState);
            switchPlayerState.setRollDiceState(rollDiceState);
            rollDiceState.setEndTurnState(endTurnState);

            return switchPlayerState;
        }
    }
}