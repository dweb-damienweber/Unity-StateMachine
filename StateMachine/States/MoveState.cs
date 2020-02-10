using System;
using UnityEngine;

public class MoveState : State
{
    #region Methods

    public override void OnStateEnter()
    {
        Debug.Log("Move state enter");
    }

    public override void OnStateExit()
    {
        Debug.Log("Move state exit");
    }

    public override Type Tick()
    {
        Debug.Log("Tick in move state");

        // Do movement

        // Random test to check if we stay in this state
        if (Input.GetKey(KeyCode.M))
            return typeof(MoveState);

        // Return to idle if no movement
        return typeof(IdleState);
    }

    #endregion
}