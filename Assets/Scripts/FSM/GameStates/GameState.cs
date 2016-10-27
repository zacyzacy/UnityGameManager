using UnityEngine;
using System.Collections;

public class GameState : FSMState
{
    public FSM _gameStateFSM;
    public override void init()
    {
        stateName = this.GetType().Name;
        _gameStateFSM = GetComponent<FSM>();
    }
}
