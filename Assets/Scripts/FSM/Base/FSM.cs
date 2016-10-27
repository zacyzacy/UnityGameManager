using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FSM : MonoBehaviour
{
    public FSMState defaultState, currentState;
    private FSMState[] states;
    private Dictionary<string, FSMState> stateMap;

    // Use this for initialization
    void Start()
    {
        stateMap = new Dictionary<string, FSMState>();
        states = GetComponents<FSMState>();
        for (int i = 0; i < states.Length; i++)
        {
            states[i].init();
            stateMap.Add(states[i].stateName, states[i]);
        }
        currentState = defaultState;
        currentState.enterState();
        currentState.isCurrentState = true;
    }
    public void ChangeState(FSMState newState)
    {
        //call current state exit
        currentState.isCurrentState = false; //make the current state execution stop
        currentState.exitState();

        //Change current state
        for (int i = 0; i < states.Length; i++)
        {
            if (states[i] == newState)
            {
                currentState = newState;
                break;
            }
        }
        //call current state enter
        currentState.enterState();
        currentState.isCurrentState = true;
    }
    public void ChangeState(string newState)
    {
        if (stateMap.ContainsKey(newState) == true)
        {
            ChangeState(stateMap[newState]);
        }
        else
        {
            Debug.LogError(newState + "does not exist in stateMap");
        }
    }
}