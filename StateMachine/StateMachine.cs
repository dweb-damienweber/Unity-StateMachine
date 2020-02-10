using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    #region System methods

    private void Update()
    {
        if (_currentState == null)
        {
            _currentState = _availableStates.Values.First();
        }

        var nextState = _currentState?.Tick();

        if (nextState != null && nextState != _currentState.GetType() && _availableStates.ContainsKey(nextState))
        {
            SwitchState(nextState);
        }
    }

    #endregion

    
    #region Methods

    public void SetStateMachine(Dictionary<Type, State> states)
    {
        _availableStates = states;
    }

    private void SwitchState(Type nextState)
    {
        _currentState.OnStateExit();
        _currentState = _availableStates[nextState];
        _currentState.OnStateEnter();
    }

    #endregion


    #region Private fields

    private State _currentState;
    private Dictionary<Type, State> _availableStates;

    #endregion
}
