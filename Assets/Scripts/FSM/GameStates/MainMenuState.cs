using UnityEngine;
using System.Collections;

public class StartScreenState : GameState
{
    public override void enterState()
    {
        //Reset everything load new instance of game starting with start screen
        _gameStateFSM.ChangeState("PlayingState");
    }
    public override void executeState()
    {
    }
    public override void exitState()
    {
    }
}
