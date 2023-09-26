using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractState : IState
{
    public Scratchpad OwnerData { get; }
    protected StateMachine OwnerStateMachine;

    protected AbstractState(Scratchpad _ownerData, StateMachine _ownerStateOwnerStateMachine)
    {
        OwnerData = _ownerData;
        OwnerStateMachine = _ownerStateOwnerStateMachine;
    }

    public abstract void Enter();
    public abstract void Update(float _delta);
    public abstract void Exit();
}
