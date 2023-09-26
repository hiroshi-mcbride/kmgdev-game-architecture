using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    public IStateRunner Owner { get; }
    private Dictionary<Type, IState> states = new Dictionary<Type, IState>();
    public IState CurrentState { get; private set; }

    public StateMachine(IStateRunner _owner, params IState[] _states)
    {
        Owner = _owner;
        foreach (IState s in _states)
        {
            states.TryAdd(s.GetType(), s);
        }
    }

    public void Update(float _delta)
    {
        CurrentState?.Update(_delta);
    }

    public void AddState(IState _state)
    {
        states.TryAdd(_state.GetType(), _state);
    }

    public void SwitchState(Type _newState)
    {
        CurrentState?.Exit();
        CurrentState = states[_newState];
        CurrentState?.Enter();
    }
}
