using System;

namespace Game.State
{
    public class PlayState : GameState
    {
        private EndState _endState;
        private Game _game;

        public Game game
        {
            get => _game;
            set => _game = value;
        }

        public override GameState update()
        {
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