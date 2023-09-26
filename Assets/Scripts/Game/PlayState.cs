using UnityEngine;

public class PlayState : AbstractState
{
    public PlayState(Scratchpad _ownerData, StateMachine _ownerStateMachine) : base(_ownerData, _ownerStateMachine)
    {
    }

    public override void Enter()
    {
        Debug.Log($"Entered {this}");
    }

    public override void Update(float _delta)
    {
        
    }

    public override void FixedUpdate(float _fixedDelta)
    {
        
    }

    public override void Exit()
    {
        
    }
}
