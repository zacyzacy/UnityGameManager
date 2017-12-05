using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown == true)
        {
            GameManager.instance.gameStateMachine.ChangeState("MainMenuState");
        }
    }
}
