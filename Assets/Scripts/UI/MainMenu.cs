using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        GameManager.instance.gameStateMachine.ChangeState("PlayingState");
    }
}
