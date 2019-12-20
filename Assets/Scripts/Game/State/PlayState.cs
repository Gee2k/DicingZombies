using System;

namespace Game.State
{
    public class PlayState : GameState
    {
        private EndState endState;
        private Game _game;

        public Game game
        {
            get => _game;
            set => _game = value;
        }

        public override GameState update()
        {
            throw new NotImplementedException();
        }

        public void setEndState(EndState endState)
        {
            this.endState = endState;
        }
    }
}