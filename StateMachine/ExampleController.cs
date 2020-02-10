using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(StateMachine))]
public class ExampleController : MonoBehaviour
{
    #region System methods

    private void Awake()
    {
        _stateMachine = GetComponent<StateMachine>();

        InitStates();
    }

    #endregion


    #region Methods

    private void InitStates()
    {
        var states = new Dictionary<Type, State>()
        {
            { typeof(IdleState), new IdleState() },
            { typeof(MoveState), new MoveState() }
        };

        _stateMachine.SetStateMachine(states);
    }

    #endregion


    #region Private fields

    private StateMachine _stateMachine;

    #endregion
}