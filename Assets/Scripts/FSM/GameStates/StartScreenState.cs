using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenState : GameState
{
    public override void enterState()
    {
        GameManager.instance.loadLevel("StartScreen");
    }
    public override void executeState()
    {
    }
    public override void exitState()
    {
        GameManager.instance.unloadLevel("StartScreen");
    }
}