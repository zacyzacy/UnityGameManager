using UnityEngine;
using System.Collections;

public class PlayingState : GameState
{
   
    public override void enterState()
    {
        GameManager.instance.running = true;
    }
    public override void executeState()
    {
    }
    public override void exitState()
    {
        GameManager.instance.running = false;
    }
}
