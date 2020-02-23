using Modules.DicingZombies.Assets.Players;
using System.Collections.Generic;
using UnityEngine;

namespace Modules.DicingZombies.Manager
{
    public class PlayerManager
    {
        private List<ZombiePlayer> players;
        private int currentIndex;


        public PlayerManager(List<ZombiePlayer> players)
        {
            this.players = players;
            currentIndex = 0;
            foreach(var player in players)
            {
                Debug.Log("Player joined: " + player.name);
            }
        }

        public ZombiePlayer switchPlayer()
        {
            currentIndex++;
            if(currentIndex >= players.Count)
            {
                currentIndex = 0;
            }
            Debug.Log("Switching to Player " + getCurrentPlayer().name);
            return getCurrentPlayer();
        }

        public ZombiePlayer getCurrentPlayer()
        {
            return players[currentIndex];
        }
    }
}
