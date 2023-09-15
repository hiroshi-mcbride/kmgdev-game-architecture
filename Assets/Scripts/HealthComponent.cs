using System;
using UnityEngine;

public class HealthComponent : MonoBehaviour, IDamageable
{
    [SerializeField] private float health = 1.0f;
    public float Health 
    { 
        get => health;
        private set => health = value;
    }

    private void Awake()
    {
        
    }

    public void TakeDamage(float _damage)
    {
        Health -= _damage;
        Debug.Log($"Took {_damage} points of damage, remaining health is {Health}");
    }
}
