using Game.State;

namespace Play.State
{
    public class RollDiceState : GameState
    {
        private RollDiceState rollDiceState;
        private EndTurnState endTurnState;

        public override GameState update()
        {
            throw new System.NotImplementedException();
        }

        public void setRollDiceState(RollDiceState gameState)
        {
            this.rollDiceState = gameState;
        }

        public void setEndTurnState(EndTurnState gameState)
        {
            this.endTurnState = gameState;
        }
    }
}