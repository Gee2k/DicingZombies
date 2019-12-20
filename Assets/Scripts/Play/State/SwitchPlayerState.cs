using Game.State;

namespace Play.State
{
    public class SwitchPlayerState : GameState
    {
        private RollDiceState rollDiceState;

        public override GameState update()
        {
            throw new System.NotImplementedException();
        }

        public void setRollDiceState(RollDiceState gameState)
        {
            this.rollDiceState = gameState;
        }
    }
}