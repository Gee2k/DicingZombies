using UnityEngine;

namespace Base.State
{
    public class PlayState : IGameState
    {
        private EndState _endState;
        private Game _game;

        public Game game
        {
            get => _game;
            set => _game = value;
        }

        public IGameState update()
        {
            Debug.Log("[PlayState] inside");
            if (_game != null)
            {
                game = game.checkGameState();
                return this;
            }
            
            // examine scoring and send to endstate
            
            return _endState;
        }

        public void SetEndState(EndState endState)
        {
            _endState = endState;
        }
    }
}