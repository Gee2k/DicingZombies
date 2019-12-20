using System;
using Game;
using Game.State;

public abstract class RuleBook
{
    public String RuleBookTitle;
    public abstract Player getRuleBookPlayer(Player player);
    public abstract GameState GetInitialPlayState();
}