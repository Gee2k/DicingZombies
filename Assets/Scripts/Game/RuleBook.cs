using System;
using Game;

public abstract class RuleBook
{
    public String RuleBookTitle;
    public abstract Player getRuleBookPlayer(Player player);
}