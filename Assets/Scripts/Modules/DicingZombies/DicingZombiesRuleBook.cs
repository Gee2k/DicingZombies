using Base;
using Base.State;
using Base.Assets;
using Modules.DicingZombies.Assets.Players;
using Modules.DicingZombies.State;
using UnityEngine;
using System.Collections.Generic;
using Modules.DicingZombies.Manager;

namespace Modules.DicingZombies
{
    public class DicingZombiesRuleBook : RuleBook
    {
        public GameObject GreenDice;
        public GameObject YellowDice;
        public GameObject RedDice;

        public DicingZombiesRuleBook()
        {
            ruleBookTitle = "DicingZombies";
            //find Models for DiceBehaviour and attach
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

        public override IGameState GetInitialPlayState()
        {
            PlayerManager playerManager = createPlayerManagerForDemo();
            EndTurnState endTurnState = new EndTurnState(playerManager);
            SwitchPlayerState switchPlayerState = new SwitchPlayerState(playerManager);
            RollDiceState rollDiceState = new RollDiceState(playerManager);

            endTurnState.setSwitchPlayerState(switchPlayerState);
            switchPlayerState.setRollDiceState(rollDiceState);
            rollDiceState.setEndTurnState(endTurnState);

            return switchPlayerState;
        }

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
    }
}