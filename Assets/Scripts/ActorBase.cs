using System;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class ActorBase : MonoBehaviour
{
    [SerializeField] protected float MovementSpeed;

    protected abstract void Move();
    
    protected abstract void Attack();
}