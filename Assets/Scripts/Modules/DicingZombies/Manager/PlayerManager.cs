using Modules.DicingZombies.Assets.Players;
using System.Collections.Generic;
using UnityEngine;
using Base.Assets;

namespace Modules.DicingZombies.Manager
{
    public class PlayerManager
    {
        private List<ZombiePlayer> _players = new List<ZombiePlayer>();
        private ZombiePlayer _activePlayer;
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
        
        public List<ZombiePlayer> players
        {
            get => _players;
            set => _players = value;
        }

        public ZombiePlayer activePlayer
        {
            get => _activePlayer;
            set => _activePlayer = value;
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
