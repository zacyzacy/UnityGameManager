using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuState : GameState
{
    public override void enterState()
    {
        GameManager.instance.loadLevel("MainMenu");
    }
    public override void executeState()
    {
    }
    public override void exitState()
    {
        GameManager.instance.unloadLevel("MainMenu");
    }
}