using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
    float h, v;
    public KeyCode[] controls;

    // Use this for initialization
    void Start()
    {
        //todo load from file for now just initialize
        //todo wrapper for controller
        //controls 0 = A, 1 = B, 2 = Start, 3 = Slect, 4 = Up, 5 = Down, 6 = Left, 7 = Right
        controls = new KeyCode[]
        {
            KeyCode.Z,KeyCode.X,KeyCode.Escape,KeyCode.Return,KeyCode.UpArrow,KeyCode.DownArrow,KeyCode.LeftArrow,KeyCode.RightArrow
        };
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStatePressCheck() == true)
        {
            return;
        }
        //other state checks
        /*
        if (true)
        {
            return;
        }
        //*/
    }
    private bool gameStatePressCheck()
    {
        if (GameManager.instance.running == false)
        {
            return false;
        }
        //A
        if (Input.GetKey(controls[0]))
        {
            GameManager.instance.player.aPress();
        }
        //B
        if (Input.GetKey(controls[1]))
        {
            GameManager.instance.player.bPress();
        }
        //Start
        if (Input.GetKey(controls[2]))
        {
            GameManager.instance.player.startPress();            
        }
        //Select
        if (Input.GetKey(controls[3]))
        {

        }
        //up
        if (Input.GetKey(controls[4]))
        {
            GameManager.instance.player.upPress();
        }
        //down
        if (Input.GetKey(controls[5]))
        {
            GameManager.instance.player.downPress();
        }
        //left
        if (Input.GetKey(controls[6]))
        {
            GameManager.instance.player.leftPress();
        }
        //right
        if (Input.GetKey(controls[7]))
        {
            GameManager.instance.player.rightPress();
        }
        //todo wrapper for controller joystick

        return true;
    }
    //controls 0 = A, 1 = B, 2 = Start, 3 = Slect, 4 = Up, 5 = Down, 6 = Left, 7 = Right
    public void rebindControl(int index, KeyCode key)
    {
        controls[index] = key;
        //need to save this array
    }
}