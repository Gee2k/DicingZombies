using System.Collections.Generic;
using Base;
using Base.State;
using Base.Assets;
using Modules.DicingZombies.Assets.Dice;
using Modules.DicingZombies.Assets.Players;
using Modules.DicingZombies.Manager;
using Modules.DicingZombies.State;
using UnityEngine;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using Modules.DicingZombies.Manager;

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
        
        //
        // Rule specific stuff
        //

        private static int MAX_HIT_COUNT = 3;
        
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
                _zombieDices.Add(new ZombieDice(ZombieDiceColorEnum.Green, greenDiceGameObject));
            }
            //create dices
            for (int i = 0; i < amountYellowDice; i++)
            {
                _zombieDices.Add(new ZombieDice(ZombieDiceColorEnum.Yellow, yellowDiceGameObject));
            }
            //create dices
            for (int i = 0; i < amountRedDice; i++)
            {
                _zombieDices.Add(new ZombieDice(ZombieDiceColorEnum.Red, redDiceGameObject));
            }
        }

        /**
         * helper method to convert a baseplayer into a zombiePlayer
         */
        public override Player getRuleBookPlayer(Player player)
        {
            return new ZombiePlayer(player.name);
        }

        /**
         * creates initial gameloop for DicingZombies
         * adds all necessary states and managers
         */
        public override IGameState SetupStateMachine()
        {
            DiceManager diceManager = new DiceManager();
            PlayerManager playerManager = createPlayerManagerForDemo();
            MenuManager menuManager = new MenuManager();
            menuManager.diceMenu = holder["DiceMenu"];

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
                gameState.menuManager = menuManager;
                gameState.ruleBook = this;
            }

            endTurnState.setSwitchPlayerState(switchPlayerState);
            switchPlayerState.setRollDiceState(rollDiceState);
            rollDiceState.setEndTurnState(endTurnState);

            return switchPlayerState;
        }

        /**
         * demo gamemanager to mimic player behaviour
         * ## mock ##
         */
        private PlayerManager createPlayerManagerForDemo()
        {
            List<ZombiePlayer> players = new List<ZombiePlayer>();
            ZombiePlayer newPlayer;
            newPlayer = new ZombiePlayer(ZombieNameGenerator.getRandomZombieName());
            players.Add(newPlayer);
            newPlayer = new ZombiePlayer(ZombieNameGenerator.getRandomZombieName());
            players.Add(newPlayer);
            newPlayer = new ZombiePlayer(ZombieNameGenerator.getRandomZombieName());
            players.Add(newPlayer);
            return new PlayerManager(players);
        }
        
        //
        // Rule specific stuff
        //
        
        public bool isPlayerDead(ZombiePlayer player)
        {
            if (player.diceShotguns.Count >= MAX_HIT_COUNT)
            {
                Debug.Log(player.name + " got shot and lost the turn");
                return true;
            }
            return false;
        }
    }
}