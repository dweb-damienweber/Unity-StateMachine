using System;
using UnityEngine;

public class IdleState : State
{
    #region System methods

    public override void OnStateEnter()
    {
        Debug.Log("Idle state enter");
    }

    public override void OnStateExit()
    {
        Debug.Log("Idle state exit");
    }

    public override Type Tick()
    {
        Debug.Log("Tick in idle state");

        // Do stuff

        // Random test. Check if movement input
        if (Input.GetKey(KeyCode.M))
            return typeof(MoveState);

        // Return to stay in this state (no call to OnStateEnter or OnStateExit)
        return typeof(IdleState);
    }

    #endregion
}