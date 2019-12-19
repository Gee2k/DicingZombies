namespace Game.State
{
    public abstract class GameState
    {
        protected GameState nextState;

        public abstract GameState update();
    }

}