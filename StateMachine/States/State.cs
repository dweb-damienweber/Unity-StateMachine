using System;

/// <summary>
/// Base class of a state
/// </summary>
public abstract class State
{
    #region Methods

    public abstract void OnStateEnter();

    public abstract Type Tick();

    public abstract void OnStateExit();

    #endregion
}
