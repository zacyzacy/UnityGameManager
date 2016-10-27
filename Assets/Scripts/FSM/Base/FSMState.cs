using UnityEngine;
using System.Collections;

public class FSMState : MonoBehaviour
{
    public bool isCurrentState;
    public string stateName;
    // Update is called once per frame
    void Update()
    {
        if (isCurrentState == true)
        {
            executeState();
        }
    }

    public virtual void init()
    {
    }
    public virtual void enterState()
    {
        //Happens once
    }
    public virtual void executeState()
    {
        //Happens every frame therefore less efficient
    }
    public virtual void exitState()
    {
        //Happens once
    }
}

