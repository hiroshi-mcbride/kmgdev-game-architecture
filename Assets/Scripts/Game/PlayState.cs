using UnityEngine;

/// <summary>
/// The primary gameplay loop is run from PlayState.
/// </summary>
public class PlayState : AbstractState
{
    private WeaponHandler weaponHandler;
    public PlayState(Scratchpad _ownerData, StateMachine _ownerStateMachine) 
        : base(_ownerData, _ownerStateMachine) { }

    public override void Enter()
    {
        base.Enter();
        OwnerData.Create(new ScoreCounter());
        weaponHandler = new WeaponHandler();
        weaponHandler.EquipWeapon();
    }

    public override void Update(float _delta)
    {
        weaponHandler.Update(_delta);
    }
}
