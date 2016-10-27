using UnityEngine;
using System.Collections;

public class PauseState : GameState
{
    public override void enterState()
    {
        //Dont Unload anything just set playing to false and spawn a pause menu prefab menu prefab
    }
    public override void executeState()
    {
    }
    public override void exitState()
    {
        //Unload Pause prefab
    }
}
