using Game;

namespace Play
{
    public class SwitchPlayerState : GameState
    {
        private GameState rollDiceState;

        public override GameState update()
        {
            throw new System.NotImplementedException();
        }

        public void setRollDiceState(GameState gameState)
        {
            this.rollDiceState = gameState;
        }
    }
}