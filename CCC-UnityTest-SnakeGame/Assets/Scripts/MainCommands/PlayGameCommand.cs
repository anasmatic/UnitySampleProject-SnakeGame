﻿
public class PlayGameCommand : Command {
    public override void Execute(Game.GameManager game)
    {
        game.StartGame();
    }
}
