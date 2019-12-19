using Game;

namespace Play
{
    public class RollDiceState : GameState
    {
        private GameState rollDiceState;
        private GameState endTurnState;

        public override GameState update()
        {
            throw new System.NotImplementedException();
        }

        public void setRollDiceState(GameState gameState)
        {
            this.rollDiceState = gameState;
        }

        public void setEndTurnState(GameState gameState)
        {
            this.endTurnState = gameState;
        }
    }
}