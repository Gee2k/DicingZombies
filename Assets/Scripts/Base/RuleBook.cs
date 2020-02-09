using System;
using Game;
using Game.State;
using Game.Assets.Player;

public abstract class RuleBook
{
    private String _ruleBookTitle;
    public abstract Player getRuleBookPlayer(Player player);
    public abstract IGameState GetInitialPlayState();

    public string ruleBookTitle
    {
        get => _ruleBookTitle;
        set => _ruleBookTitle = value;
    }
}