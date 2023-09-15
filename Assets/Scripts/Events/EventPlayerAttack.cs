using System;
using UnityEngine;

public struct EventPlayerAttack : IEvent
{
    public float Damage { get; }
    public LayerMask AttackHitMask { get; }

    public EventPlayerAttack(float _damage, LayerMask _attackHitMask)
    {
        Damage = _damage;
        AttackHitMask = _attackHitMask;
    }
}
