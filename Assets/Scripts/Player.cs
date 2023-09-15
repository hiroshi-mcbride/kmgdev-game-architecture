using System;
using UnityEngine;
public class Player : ActorBase
{
    [SerializeField] private LayerMask attackHitMask;
        
    private void Awake()
    {
    }

    private void Update()
    {
        Move();
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    protected override void Move()
    {
        Vector3 inputVector = new Vector3(Input.GetAxisRaw("Horizontal"), .0f, Input.GetAxisRaw("Vertical")).normalized;
        transform.Translate(inputVector * (MovementSpeed * Time.deltaTime));
    }

    protected override void Attack()
    {
        EventManager.Invoke(new EventPlayerAttack(2.0f, attackHitMask));
    }
}
