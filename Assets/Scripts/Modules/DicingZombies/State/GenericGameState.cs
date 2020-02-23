using Modules.DicingZombies.Manager;

namespace Modules.DicingZombies.State
{
     public class GenericGameState
    {
        protected PlayerManager _playerManager;

        public GenericGameState(PlayerManager playerManager) 
        {
            this._playerManager = playerManager;
        }
}
}