using System.Collections.Generic;
using Base.Assets;
using Modules.DicingZombies.Assets.Players;

namespace Modules.DicingZombies.Manager
{
    public class PlayerManager
    {
        private List<ZombiePlayer> _players = new List<ZombiePlayer>();
        private ZombiePlayer _activePlayer;

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
    }
}
