namespace States
{
    public abstract class GameState
    {
        protected GameState nextState;

        public abstract GameState update();
    }

}